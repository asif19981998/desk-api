using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Desk.Services.Employees.OtherInformations
{
    public interface IOtherInformationService
    {

        Task<IEnumerable<OtherInformation>> GetAllAsync();
        Task<IEnumerable<OtherInformation>> GetAllDeletedAsync();
        Task<OtherInformation> GetByIdAsync(long id);
        Task<OtherInformation> AddAsync(OtherInformation model);
        Task<bool> UpdateAsync(OtherInformation model);
        Task<bool> SoftDeleteAsync(OtherInformation model);
        Task<bool> RestoreAsync(OtherInformation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(OtherInformation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<OtherInformation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<OtherInformation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
