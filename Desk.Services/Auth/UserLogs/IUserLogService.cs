using Desk.Core.Domain.Auth;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Auth.UserLogs
{
    public interface IUserLogService
    {
        Task<IEnumerable<UserLog>> GetAllAsync();
        Task<IEnumerable<UserLog>> GetAllDeletedAsync();
        Task<UserLog> GetByIdAsync(long id);
        Task<UserLog> AddAsync(UserLog model);
        Task<bool> UpdateAsync(UserLog model);
        Task<bool> SoftDeleteAsync(UserLog model);
        Task<bool> RestoreAsync(UserLog model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(UserLog model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<UserLog>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<UserLog>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
