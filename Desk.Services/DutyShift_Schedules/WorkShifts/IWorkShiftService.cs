using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.DutyShift_Schedules.WorkShifts
{
    public interface IWorkShiftService
    {
        Task<IEnumerable<WorkShift>> GetAllAsync();
        Task<IEnumerable<WorkShift>> GetAllDeletedAsync();
        Task<WorkShift> GetByIdAsync(long id);
        Task<WorkShift> AddAsync(WorkShift model);
        Task<bool> UpdateAsync(WorkShift model);
        Task<bool> SoftDeleteAsync(WorkShift model);
        Task<bool> RestoreAsync(WorkShift model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(WorkShift model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<WorkShift>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<WorkShift>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
