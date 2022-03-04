using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.DutyShift_Schedules.WeekDaysShifts
{
    public interface IWeekDaysShiftService
    {
        Task<IEnumerable<WeekDaysShift>> GetAllAsync();
        Task<IEnumerable<WeekDaysShift>> GetAllDeletedAsync();
        Task<WeekDaysShift> GetByIdAsync(long id);
        Task<WeekDaysShift> AddAsync(WeekDaysShift model);
        Task<bool> UpdateAsync(WeekDaysShift model);
        Task<bool> SoftDeleteAsync(WeekDaysShift model);
        Task<bool> RestoreAsync(WeekDaysShift model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(WeekDaysShift model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<WeekDaysShift>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<WeekDaysShift>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
