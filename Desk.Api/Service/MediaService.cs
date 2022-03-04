using Desk.Core.Domain.Media;
using Desk.Core.Enums;
using Desk.Core.Exceptions;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using Desk.Infrastructure.Extensions;
using Desk.Infrastructure.Interfaces;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Api.Service
{
    public class MediaService : IMediaService
    {
        #region Constant
        public const string foldername = "useruploads";
        public const string CompressedThumb = "~/staticfiles/compressed.jpg";
        public const string DocumentThumb = "~/staticfiles/document.png";
        public const string ExcelThumb = "~/staticfiles/excel.png";
        public const string OthersThumb = "~/staticfiles/others.png";
        public const string PdfThumb = "~/staticfiles/pdf.png";
        public const string PptThumb = "~/staticfiles/ppt.png";
        public const string VideoThumb = "~/staticfiles/video.png";
        public const string AudioThumb = "~/staticfiles/audio.png";
        #endregion
        #region ctor
        private IWebHostEnvironment webHost;
        private IEntityRepository<MediaFile> mediaRepository;
        private IWorkContext workContext;

        public MediaService(IWebHostEnvironment webHost,
            IEntityRepository<MediaFile> mediaRepository,
            IWorkContext workContext)
        {
            this.webHost = webHost;
            this.mediaRepository = mediaRepository;
            this.workContext = workContext;
        }

        #endregion
        #region methods
        public MediaFile UploadFile(IFormFile file)
        {
            return UploadFileInFolder(file);

        }
        public void UpdateFile(MediaFile media, IFormFile file)
        {
            if (media.FileUrl != null)
            {
                if (media.MediaType == MediaType.Image)
                {
                    DeleteFileInFolder(media.ThumbnailUrl);
                }
                DeleteFileInFolder(media.FileUrl);
            }
            UpdateFileInFolder(media, file);
        }
        public MediaFile GetById(long id)
        {
            try
            {
                var media = mediaRepository.GetByIdAsync(id).Result;
                return media;
            }
            catch (Exception)
            {
                throw new NotFoundException();
            }
        }
        public void DeleteFile(string fileurl, string thumburl, int mediaType)
        {
            if (mediaType == (int)MediaType.Image)
            {
                DeleteFileInFolder(thumburl);
            }
            DeleteFileInFolder(fileurl);
        }
        public void DeleteFileWithMedia(MediaFile media)
        {
            if (media.MediaType == MediaType.Image)
            {
                DeleteFileInFolder(media.ThumbnailUrl);
            }
            DeleteFileInFolder(media.FileUrl);
            mediaRepository.PermanentDeleteAsync(media);
        }
        #endregion
        #region functions
        public void DeleteFileInFolder(string filename)
        {
            string dbpath = filename.Replace("~/", "").ToString();
            string uppath = dbpath.Replace("/", "\\").ToString();
            string fullpath = webHost.WebRootPath + "\\" + uppath;
            System.IO.File.Delete(fullpath);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public MediaFile UploadFileInFolder(IFormFile file)
        {
            string baseFileName = file.FileName;
            MediaThumbnailModel model = SaveIcon(file);
            MediaFile media = new MediaFile()
            {
                FileName = baseFileName,
                FileSize = Convert.ToInt64(file.Length),
                FileUrl = SaveFile(file),
                ThumbnailUrl = model.ThumbnailUrl,
                MediaType = model.MediaType,
                CreatedBy =workContext.GetCurrentUserAsync().Result.Id,
                CreatedOn =DateTime.Now,
                
            };

            var dbmedia = mediaRepository.AddAsync(media).Result;
            return dbmedia;

        }
        private void UpdateFileInFolder(MediaFile media, IFormFile file)
        {
            string baseFileName = file.FileName;
            MediaThumbnailModel model = SaveIcon(file);

            media.FileName = baseFileName;
            media.FileSize = Convert.ToInt64(file.Length);
            media.FileUrl = SaveFile(file);
            media.ThumbnailUrl = model.ThumbnailUrl;
            media.MediaType = model.MediaType;
            media.UpdatedBy = workContext.GetCurrentUserAsync().Result.Id;
            media.UpdatedOn = DateTime.Now;
            mediaRepository.UpdateAsync(media);
        }
        public string SaveFile(IFormFile file)
        {
            Guid nameguid = Guid.NewGuid();
            string webrootpath = webHost.WebRootPath;
            string filename = nameguid.ToString();
            string extension = Path.GetExtension(file.FileName);
            filename = filename + extension;
            string path = Path.Combine(webrootpath, foldername, filename);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            string pathName = Path.Combine(foldername, filename);
            string fileUrl = "~/" + foldername + "/" + filename;
            return fileUrl;
        }
        private MediaThumbnailModel SaveIcon(IFormFile file)
        {
            MediaType mediaType = GetMediaType(file);
            if (mediaType == MediaType.Image)
            {
                Guid nameguid = Guid.NewGuid();
                string webrootpath = webHost.WebRootPath;
                string filename = nameguid.ToString();
                string extension = Path.GetExtension(file.FileName);
                filename = filename + extension;

                using (var stream = file.OpenReadStream())
                {
                    var uploadedImage = Image.FromStream(stream);

                    //returns Image file
                    var img = ImageResize.ScaleAndCrop(uploadedImage, 200, 200);
                    string path = Path.Combine(webrootpath, foldername, filename);

                    uploadedImage.SaveAs(path);
                }
                string fileUrl = "~/" + foldername + "/" + filename;

                MediaThumbnailModel model = new MediaThumbnailModel()
                {
                    MediaType = mediaType,
                    ThumbnailUrl = fileUrl
                };
                return model;
            }
            else
            {
                string fileurl = GetThumbnailForFile(mediaType);
                MediaThumbnailModel model = new MediaThumbnailModel()
                {
                    MediaType = mediaType,
                    ThumbnailUrl = fileurl
                };
                return model;
            }

        }
        private string GetThumbnailForFile(MediaType mediaType)
        {
            if (mediaType == MediaType.Audio)
                return AudioThumb;
            if (mediaType == MediaType.Video)
                return VideoThumb;
            if (mediaType == MediaType.PDF)
                return PdfThumb;
            if (mediaType == MediaType.DOC)
                return DocumentThumb;
            if (mediaType == MediaType.XLS)
                return ExcelThumb;
            if (mediaType == MediaType.PPT)
                return PptThumb;
            if (mediaType == MediaType.Compressed)
                return CompressedThumb;
            else
                return OthersThumb;
        }
        private MediaType GetMediaType(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);

            if (FileExtensions.Audio.Contains(extension))
                return MediaType.Audio;
            if (FileExtensions.Video.Contains(extension))
                return MediaType.Video;
            if (FileExtensions.Pdf.Contains(extension))
                return MediaType.PDF;
            if (FileExtensions.Doc.Contains(extension))
                return MediaType.DOC;
            if (FileExtensions.Xls.Contains(extension))
                return MediaType.XLS;
            if (FileExtensions.Ppt.Contains(extension))
                return MediaType.PPT;
            if (FileExtensions.Compressed.Contains(extension))
                return MediaType.Compressed;
            return MediaType.Others;
        }
     
        #endregion

    }
    public class MediaThumbnailModel
    {
        public MediaType MediaType { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}