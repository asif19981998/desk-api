using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeeSalaries
{
    public interface IFamilySevice
    {
        Task<IEnumerable<Family>> GetAllAsync();
        Task<IEnumerable<Family>> GetAllDeletedAsync();
        Task<Family> GetByIdAsync(long id);
        Task<Family> AddAsync(Family model);
        Task<bool> UpdateAsync(Family model);
        Task<bool> SoftDeleteAsync(Family model);
        Task<bool> RestoreAsync(Family model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Family model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Family>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Family>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
