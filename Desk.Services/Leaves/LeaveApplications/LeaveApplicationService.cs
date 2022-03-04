using Desk.Core.Domain.Leave;
using Desk.Core.Enums;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Leaves.LeaveApplications
{

    public class LeaveApplicationService : ILeaveApplicationService
    {
        private readonly IEntityRepository<LeaveApplication> _repository;

        public LeaveApplicationService(IEntityRepository<LeaveApplication> repository)
        {
            _repository = repository;
        }
        public async Task<LeaveApplication> AddAsync(LeaveApplication model)
        {
            model.LeaveApplicationStatus = LeaveApplicationStatus.New;
            model.CreatedOn = DateTime.Now;
            return await _repository.AddAsync(model);
        }

        public async Task<bool> PermanentDeleteAsync(LeaveApplication model)
        {
            return await _repository.PermanentDeleteAsync(model);
        }

        public async Task<bool> PermanentDeleteByIdAsync(long id)
        {
            return await _repository.PermanentDeleteByIdAsync(id);
        }

        public async Task<IEnumerable<LeaveApplication>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<LeaveApplication> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public int TotalCount()
        {
            return _repository.CountAsync().Result;
        }

        public async Task<bool> UpdateAsync(LeaveApplication model)
        {
            return await _repository.UpdateAsync(model);
        }

        public async Task<bool> SoftDeleteAsync(LeaveApplication model)
        {
            model.LeaveApplicationStatus = LeaveApplicationStatus.Accepted;
            return await _repository.SoftDeleteAsync(model);
        }

        public async Task<bool> SoftDeleteByIdAsync(long id)
        {
            return await _repository.SoftDeleteByIdAsync(id);
        }

        public async Task<PagedModel<LeaveApplication>> GetPagedListAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetAllPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<LeaveApplication> pagedModel = new PagedModel<LeaveApplication>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<PagedModel<LeaveApplication>> GetDeletedPagedAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetDeletedPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<LeaveApplication> pagedModel = new PagedModel<LeaveApplication>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<IEnumerable<LeaveApplication>> GetAllDeletedAsync()
        {
            return await _repository.GetAllDeletedAsync();
        }

        public async Task<bool> RestoreAsync(LeaveApplication model)
        {
            return await _repository.RestoreAsync(model);
        }

        public async Task<bool> RestoreByIdAsync(long id)
        {
            return await _repository.RestoreByIdAsync(id);
        }

        public async Task<bool> RestoreByIdsAsync(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public async Task<LeaveApplication> GetLeaveStatus(long id)
        {
            throw new NotImplementedException();

        }

        public Task<LeaveApplication> UpdateLeaveStatus(long id)
        {
            throw new NotImplementedException();
        }
    }
}

