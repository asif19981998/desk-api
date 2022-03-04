using Desk.Core.Domain.Attendance;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Attendance.Holidays
{
    public interface IHolidayService
    {
        Task<IEnumerable<Holiday>> GetAllAsync();
        Task<IEnumerable<Holiday>> GetAllDeletedAsync();
        Task<Holiday> GetByIdAsync(long id);
        Task<Holiday> AddAsync(Holiday model);
        Task<bool> UpdateAsync(Holiday model);
        Task<bool> SoftDeleteAsync(Holiday model);
        Task<bool> RestoreAsync(Holiday model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Holiday model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Holiday>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Holiday>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
