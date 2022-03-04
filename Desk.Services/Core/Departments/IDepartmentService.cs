using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Departments
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task<IEnumerable<Department>> GetAllDeletedAsync();
        Task<Department> GetByIdAsync(long id);
        Task<Department> AddAsync(Department model);
        Task<bool> UpdateAsync(Department model);
        Task<bool> SoftDeleteAsync(Department model);
        Task<bool> RestoreAsync(Department model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Department model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Department>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Department>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
