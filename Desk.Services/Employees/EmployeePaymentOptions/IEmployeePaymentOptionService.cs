using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.EmployeePaymentOptions
{
    public interface IEmployeePaymentOptionService
    {
        Task<IEnumerable<EmployeePaymentOption>> GetAllAsync();
        Task<IEnumerable<EmployeePaymentOption>> GetAllDeletedAsync();
        Task<EmployeePaymentOption> GetByIdAsync(long id);
        Task<EmployeePaymentOption> AddAsync(EmployeePaymentOption model);
        Task<bool> UpdateAsync(EmployeePaymentOption model);
        Task<bool> SoftDeleteAsync(EmployeePaymentOption model);
        Task<bool> RestoreAsync(EmployeePaymentOption model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(EmployeePaymentOption model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<EmployeePaymentOption>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<EmployeePaymentOption>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
