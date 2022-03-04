using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.DutyShift_Schedules.EmployeeWorkSchedules
{
    public interface IEmployeeWorkScheduleService
    {
        Task<IEnumerable<EmployeeWorkSchedule>> GetAllAsync();
        Task<IEnumerable<EmployeeWorkSchedule>> GetAllDeletedAsync();
        Task<EmployeeWorkSchedule> GetByIdAsync(long id);
        Task<EmployeeWorkSchedule> AddAsync(EmployeeWorkSchedule model);
        Task<bool> UpdateAsync(EmployeeWorkSchedule model);
        Task<bool> SoftDeleteAsync(EmployeeWorkSchedule model);
        Task<bool> RestoreAsync(EmployeeWorkSchedule model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeWorkSchedule model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeWorkSchedule>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeWorkSchedule>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
