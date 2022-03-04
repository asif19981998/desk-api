using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeeExperiences
{
    public interface IEmployeeExperienceService
    {
        Task<IEnumerable<EmployeeExperience>> GetAllAsync();
        Task<IEnumerable<EmployeeExperience>> GetAllDeletedAsync();
        Task<EmployeeExperience> GetByIdAsync(long id);
        Task<EmployeeExperience> AddAsync(EmployeeExperience model);
        Task<bool> UpdateAsync(EmployeeExperience model);
        Task<bool> SoftDeleteAsync(EmployeeExperience model);
        Task<bool> RestoreAsync(EmployeeExperience model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeExperience model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeExperience>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeExperience>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
