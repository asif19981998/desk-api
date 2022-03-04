using Desk.Core.Domain.Auth;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Auth.Permissions
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetAllAsync();
        Task<IEnumerable<Permission>> GetAllDeletedAsync();
        Task<Permission> GetByIdAsync(long id);
        Task<Permission> AddAsync(Permission model);
        Task<bool> UpdateAsync(Permission model);
        Task<bool> SoftDeleteAsync(Permission model);
        Task<bool> RestoreAsync(Permission model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Permission model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Permission>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Permission>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
