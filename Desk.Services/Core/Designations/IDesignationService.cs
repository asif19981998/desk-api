using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Designations
{
    public interface IDesignationService
    {
        Task<IEnumerable<Designation>> GetAllAsync();
        Task<IEnumerable<Designation>> GetAllDeletedAsync();
        Task<Designation> GetByIdAsync(long id);
        Task<Designation> AddAsync(Designation model);
        Task<bool> UpdateAsync(Designation model);
        Task<bool> SoftDeleteAsync(Designation model);
        Task<bool> RestoreAsync(Designation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Designation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Designation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Designation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
