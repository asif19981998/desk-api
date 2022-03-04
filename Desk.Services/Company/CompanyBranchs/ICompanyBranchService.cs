using Desk.Core.Domain.Company;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Company.CompanyBranchs
{
    public interface  ICompanyBranchService
    {
        Task<IEnumerable<CompanyBranch>> GetAllAsync();
        Task<IEnumerable<CompanyBranch>> GetAllDeletedAsync();
        Task<CompanyBranch> GetByIdAsync(long id);
        Task<CompanyBranch> AddAsync(CompanyBranch model);
        Task<bool> UpdateAsync(CompanyBranch model);
        Task<bool> SoftDeleteAsync(CompanyBranch model);
        Task<bool> RestoreAsync(CompanyBranch model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(CompanyBranch model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<CompanyBranch>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<CompanyBranch>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
