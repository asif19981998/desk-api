using Desk.Core.Domain.Company;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Company.CompanyContactInformations
{
    public interface ICompanyContactInformationService
    {
        Task<IEnumerable<CompanyContactInformation>> GetAllAsync();
        Task<IEnumerable<CompanyContactInformation>> GetAllDeletedAsync();
        Task<CompanyContactInformation> GetByIdAsync(long id);
        Task<CompanyContactInformation> AddAsync(CompanyContactInformation model);
        Task<bool> UpdateAsync(CompanyContactInformation model);
        Task<bool> SoftDeleteAsync(CompanyContactInformation model);
        Task<bool> RestoreAsync(CompanyContactInformation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(CompanyContactInformation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<CompanyContactInformation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<CompanyContactInformation>> GetDeletedPagedAsync(int page, int pageSize);

    }
}
