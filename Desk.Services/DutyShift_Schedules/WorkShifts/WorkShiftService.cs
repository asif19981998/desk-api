using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.DutyShift_Schedules.WorkShifts
{
    public class WorkShiftService:IWorkShiftService
    {
        private readonly IEntityRepository<WorkShift> _repository;

        public WorkShiftService(IEntityRepository<WorkShift> repository)
        {
            _repository = repository;
        }
        public async Task<WorkShift> AddAsync(WorkShift model)
        {
            model.CreatedOn = DateTime.Now;
            return await _repository.AddAsync(model);
        }

        public async Task<bool> PermanentDeleteAsync(WorkShift model)
        {
            return await _repository.PermanentDeleteAsync(model);
        }

        public async Task<bool> PermanentDeleteByIdAsync(long id)
        {
            return await _repository.PermanentDeleteByIdAsync(id);
        }

        public async Task<IEnumerable<WorkShift>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<WorkShift> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public int TotalCount()
        {
            return _repository.CountAsync().Result;
        }

        public async Task<bool> UpdateAsync(WorkShift model)
        {
            return await _repository.UpdateAsync(model);
        }

        public async Task<bool> SoftDeleteAsync(WorkShift model)
        {
            return await _repository.SoftDeleteAsync(model);
        }

        public async Task<bool> SoftDeleteByIdAsync(long id)
        {
            return await _repository.SoftDeleteByIdAsync(id);
        }

        public async Task<PagedModel<WorkShift>> GetPagedListAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetAllPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<WorkShift> pagedModel = new PagedModel<WorkShift>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<PagedModel<WorkShift>> GetDeletedPagedAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetDeletedPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<WorkShift> pagedModel = new PagedModel<WorkShift>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<IEnumerable<WorkShift>> GetAllDeletedAsync()
        {
            return await _repository.GetAllDeletedAsync();
        }

        public async Task<bool> RestoreAsync(WorkShift model)
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
    }
}
