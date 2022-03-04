using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeeEducations
{
    public interface IEmployeeEducationService
    {
        Task<IEnumerable<EmployeeEducation>> GetAllAsync();
        Task<IEnumerable<EmployeeEducation>> GetAllDeletedAsync();
        Task<EmployeeEducation> GetByIdAsync(long id);
        Task<EmployeeEducation> AddAsync(EmployeeEducation model);
        Task<bool> UpdateAsync(EmployeeEducation model);
        Task<bool> SoftDeleteAsync(EmployeeEducation model);
        Task<bool> RestoreAsync(EmployeeEducation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeEducation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeEducation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeEducation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
