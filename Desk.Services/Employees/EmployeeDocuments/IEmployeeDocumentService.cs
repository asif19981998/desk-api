using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeeDocuments
{
    public interface IEmployeeDocumentService
    {
        Task<IEnumerable<EmployeeDocument>> GetAllAsync();
        Task<IEnumerable<EmployeeDocument>> GetAllDeletedAsync();
        Task<EmployeeDocument> GetByIdAsync(long id);
        Task<EmployeeDocument> AddAsync(EmployeeDocument model);
        Task<bool> UpdateAsync(EmployeeDocument model);
        Task<bool> SoftDeleteAsync(EmployeeDocument model);
        Task<bool> RestoreAsync(EmployeeDocument model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeDocument model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeDocument>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeDocument>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
