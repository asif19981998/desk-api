using Desk.Core.Domain.Attendance;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Attendance.EmployeeAtttendances
{
    public interface IEmployeeAttendanceService
    {
        Task<IEnumerable<EmployeeAttendance>> GetAllAsync();
        Task<IEnumerable<EmployeeAttendance>> GetAllDeletedAsync();
        Task<EmployeeAttendance> GetByIdAsync(long id);
        Task<EmployeeAttendance> AddAsync(EmployeeAttendance model);
        Task<bool> UpdateAsync(EmployeeAttendance model);
        Task<bool> SoftDeleteAsync(EmployeeAttendance model);
        Task<bool> RestoreAsync(EmployeeAttendance model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeAttendance model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeAttendance>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeAttendance>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
