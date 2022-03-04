using Desk.Core.Domain.Auth;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Auth.RolePermissions
{
    public interface IRolePermissionService
    {
        Task<IEnumerable<RolePermission>> GetAllAsync();
        Task<IEnumerable<RolePermission>> GetAllDeletedAsync();
        Task<RolePermission> GetByIdAsync(long id);
        Task<RolePermission> AddAsync(RolePermission model);
        Task<bool> UpdateAsync(RolePermission model);
        Task<bool> SoftDeleteAsync(RolePermission model);
        Task<bool> RestoreAsync(RolePermission model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(RolePermission model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<RolePermission>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<RolePermission>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
