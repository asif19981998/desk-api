using Desk.Core.Domain.Company;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Company.CompanyInformations
{
    public interface ICompanyInformationService
    {
        Task<IEnumerable<CompanyInformation>> GetAllAsync();
        Task<IEnumerable<CompanyInformation>> GetAllDeletedAsync();
        Task<CompanyInformation> GetByIdAsync(long id);
        Task<CompanyInformation> AddAsync(CompanyInformation model);
        Task<bool> UpdateAsync(CompanyInformation model);
        Task<bool> SoftDeleteAsync(CompanyInformation model);
        Task<bool> RestoreAsync(CompanyInformation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(CompanyInformation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<CompanyInformation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<CompanyInformation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
