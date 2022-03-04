using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.Employees
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<IEnumerable<Employee>> GetAllDeletedAsync();
        Task<Employee> GetByIdAsync(long id);
        Task<Employee> AddAsync(Employee model);
        Task<bool> UpdateAsync(Employee model);
        Task<bool> SoftDeleteAsync(Employee model);
        Task<bool> RestoreAsync(Employee model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Employee model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Employee>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Employee>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
