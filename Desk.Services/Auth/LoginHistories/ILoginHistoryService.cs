using Desk.Core.Domain.Auth;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Auth.LoginHistories
{
    public interface ILoginHistoryService
    {
        Task<IEnumerable<LoginHistory>> GetAllAsync();
        Task<IEnumerable<LoginHistory>> GetAllDeletedAsync();
        Task<LoginHistory> GetByIdAsync(long id);
        Task<LoginHistory> AddAsync(LoginHistory model);
        Task<bool> UpdateAsync(LoginHistory model);
        Task<bool> SoftDeleteAsync(LoginHistory model);
        Task<bool> RestoreAsync(LoginHistory model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(LoginHistory model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<LoginHistory>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<LoginHistory>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
