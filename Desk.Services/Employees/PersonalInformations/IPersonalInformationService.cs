using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desk.Core.Miscellaneous;
namespace Desk.Services.Employees.PersonalInformations
{
    public interface IPersonalInformationService
    {
        Task<IEnumerable<PersonalInformation>> GetAllAsync();
        Task<IEnumerable<PersonalInformation>> GetAllDeletedAsync();
        Task<PersonalInformation> GetByIdAsync(long id);
        Task<PersonalInformation> AddAsync(PersonalInformation model);
        Task<bool> UpdateAsync(PersonalInformation model);
        Task<bool> SoftDeleteAsync(PersonalInformation model);
        Task<bool> RestoreAsync(PersonalInformation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(PersonalInformation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<PersonalInformation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<PersonalInformation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
