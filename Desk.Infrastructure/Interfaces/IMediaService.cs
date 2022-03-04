using Desk.Core.Domain.Media;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Interfaces
{

    public interface IMediaService
    {
        MediaFile UploadFile(IFormFile file);
        void UpdateFile(MediaFile media, IFormFile file);
        MediaFile GetById(long id);
        void DeleteFile(string fileurl, string thumburl, int mediaType);
        void DeleteFileWithMedia(MediaFile media);
    }
}
