using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Desk.Services.Employees.EmployeementTerms
{
    public interface IEmployeementTermService
    {

        Task<IEnumerable<EmployeementTerm>> GetAllAsync();
        Task<IEnumerable<EmployeementTerm>> GetAllDeletedAsync();
        Task<EmployeementTerm> GetByIdAsync(long id);
        Task<EmployeementTerm> AddAsync(EmployeementTerm model);
        Task<bool> UpdateAsync(EmployeementTerm model);
        Task<bool> SoftDeleteAsync(EmployeementTerm model);
        Task<bool> RestoreAsync(EmployeementTerm model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeementTerm model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeementTerm>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeementTerm>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
