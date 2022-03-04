using Desk.Core.Domain.Leave;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Leaves.LeaveApplications
{
    public interface ILeaveApplicationService
    {
        Task<IEnumerable<LeaveApplication>> GetAllAsync();
        Task<IEnumerable<LeaveApplication>> GetAllDeletedAsync();
        Task<LeaveApplication> GetByIdAsync(long id);
        Task<LeaveApplication> AddAsync(LeaveApplication model);
        Task<bool> UpdateAsync(LeaveApplication model);
        Task<bool> SoftDeleteAsync(LeaveApplication model);
        Task<bool> RestoreAsync(LeaveApplication model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(LeaveApplication model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        Task<LeaveApplication> GetLeaveStatus(long id);
        Task<LeaveApplication> UpdateLeaveStatus(long id);
        int TotalCount();
        Task<PagedModel<LeaveApplication>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<LeaveApplication>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
