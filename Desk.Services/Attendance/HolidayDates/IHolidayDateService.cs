using Desk.Core.Domain.Attendance;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Attendance.HolidayDates
{
    public interface IHolidayDateService
    {
        Task<IEnumerable<HolidayDate>> GetAllAsync();
        Task<IEnumerable<HolidayDate>> GetAllDeletedAsync();
        Task<HolidayDate> GetByIdAsync(long id);
        Task<HolidayDate> AddAsync(HolidayDate model);
        Task<bool> UpdateAsync(HolidayDate model);
        Task<bool> SoftDeleteAsync(HolidayDate model);
        Task<bool> RestoreAsync(HolidayDate model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(HolidayDate model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<HolidayDate>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<HolidayDate>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
