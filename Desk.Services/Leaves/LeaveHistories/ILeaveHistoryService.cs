using Desk.Core.Domain.Leave;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Leaves.LeaveHistories
{
    public interface ILeaveHistoryService
    {
        Task<IEnumerable<LeaveHistory>> GetAllAsync();
        Task<IEnumerable<LeaveHistory>> GetAllDeletedAsync();
        Task<LeaveHistory> GetByIdAsync(long id);
        Task<LeaveHistory> AddAsync(LeaveHistory model);
        Task<bool> UpdateAsync(LeaveHistory model);
        Task<bool> SoftDeleteAsync(LeaveHistory model);
        Task<bool> RestoreAsync(LeaveHistory model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(LeaveHistory model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<LeaveHistory>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<LeaveHistory>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
