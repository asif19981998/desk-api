using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeeSalaries
{
    public interface IEmployeeSalaryService
    {
        Task<IEnumerable<EmployeeSalary>> GetAllAsync();
        Task<IEnumerable<EmployeeSalary>> GetAllDeletedAsync();
        Task<EmployeeSalary> GetByIdAsync(long id);
        Task<EmployeeSalary> AddAsync(EmployeeSalary model);
        Task<bool> UpdateAsync(EmployeeSalary model);
        Task<bool> SoftDeleteAsync(EmployeeSalary model);
        Task<bool> RestoreAsync(EmployeeSalary model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeSalary model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeSalary>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeSalary>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
