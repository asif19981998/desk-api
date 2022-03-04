using Desk.Core.Domain.Attendance;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Attendance.EmployeeLateHistories
{
    public interface IEmployeeLateHistoryService
    {
        Task<IEnumerable<EmployeeLateHistory>> GetAllAsync();
        Task<IEnumerable<EmployeeLateHistory>> GetAllDeletedAsync();
        Task<EmployeeLateHistory> GetByIdAsync(long id);
        Task<EmployeeLateHistory> AddAsync(EmployeeLateHistory model);
        Task<bool> UpdateAsync(EmployeeLateHistory model);
        Task<bool> SoftDeleteAsync(EmployeeLateHistory model);
        Task<bool> RestoreAsync(EmployeeLateHistory model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeLateHistory model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeLateHistory>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeLateHistory>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
