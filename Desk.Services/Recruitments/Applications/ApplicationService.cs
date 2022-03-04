using Desk.Core.Domain.Recruitments;
using Desk.Core.Enums;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using Desk.Services.Recruitments.Applications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Recruitments.Applications
{
    public class ApplicationService : IApplicationService
    {
        private readonly IEntityRepository<Application> _repository;

        public ApplicationService(IEntityRepository<Application> repository)
        {
            _repository = repository;
        }


        public async Task<Application> AddAsync(Application model)
        {
            model.CreatedOn = DateTime.Now;
            model.ApplicationStatus = ApplicationStatus.New;
            return await _repository.AddAsync(model);
        }

        public async Task<bool> PermanentDeleteAsync(Application model)
        {
            return await _repository.PermanentDeleteAsync(model);
        }

        public async Task<bool> PermanentDeleteByIdAsync(long id)
        {
            return await _repository.PermanentDeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Application>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Application> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public int TotalCount()
        {
            return _repository.CountAsync().Result;
        }

        public async Task<bool> UpdateAsync(Application model)
        {
            model.ApplicationStatus = ApplicationStatus.Accepted;

            return await _repository.UpdateAsync(model);
        }

        public async Task<bool> SoftDeleteAsync(Application model)
        {
            return await _repository.SoftDeleteAsync(model);
        }

        public async Task<bool> SoftDeleteByIdAsync(long id)
        {
            return await _repository.SoftDeleteByIdAsync(id);
        }

        public async Task<PagedModel<Application>> GetPagedListAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetAllPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<Application> pagedModel = new PagedModel<Application>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<PagedModel<Application>> GetDeletedPagedAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetDeletedPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<Application> pagedModel = new PagedModel<Application>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<IEnumerable<Application>> GetAllDeletedAsync()
        {
            return await _repository.GetAllDeletedAsync();
        }

        public async Task<bool> RestoreAsync(Application model)
        {
            return await _repository.RestoreAsync(model);
        }

        public async Task<bool> RestoreByIdAsync(long id)
        {
            return await _repository.RestoreByIdAsync(id);
        }

        public Task<bool> RestoreByIdsAsync(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationStatusModel> GetApplicationStatusById(long id)
        {
            Application application = await _repository.GetByIdAsync(id);
            ApplicationStatusModel model = new ApplicationStatusModel() { ApplicationId = application.Id, ApplicationStatus = application.ApplicationStatus };
            return model;
        }
    }
}
