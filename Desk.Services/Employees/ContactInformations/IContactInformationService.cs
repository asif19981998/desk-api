using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.ContactInformations
{
    public interface IContactInformationService
    {
        Task<IEnumerable<ContactInformation>> GetAllAsync();
        Task<IEnumerable<ContactInformation>> GetAllDeletedAsync();
        Task<ContactInformation> GetByIdAsync(long id);
        Task<ContactInformation> AddAsync(ContactInformation model);
        Task<bool> UpdateAsync(ContactInformation model);
        Task<bool> SoftDeleteAsync(ContactInformation model);
        Task<bool> RestoreAsync(ContactInformation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(ContactInformation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<ContactInformation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<ContactInformation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
