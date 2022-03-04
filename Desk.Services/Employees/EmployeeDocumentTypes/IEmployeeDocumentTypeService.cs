
using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeeDocumentTypes
{
    public interface IEmployeeDocumentTypeService
    {
        Task<IEnumerable<EmployeeDocumentType>> GetAllAsync();
        Task<IEnumerable<EmployeeDocumentType>> GetAllDeletedAsync();
        Task<EmployeeDocumentType> GetByIdAsync(long id);
        Task<EmployeeDocumentType> AddAsync(EmployeeDocumentType model);
        Task<bool> UpdateAsync(EmployeeDocumentType model);
        Task<bool> SoftDeleteAsync(EmployeeDocumentType model);
        Task<bool> RestoreAsync(EmployeeDocumentType model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeeDocumentType model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeeDocumentType>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeeDocumentType>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
