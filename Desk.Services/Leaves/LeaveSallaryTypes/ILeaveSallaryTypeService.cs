using Desk.Core.Domain.Leave;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Leaves.LeaveSallaries
{
    public interface ILeaveSallaryTypeService
    {
        Task<IEnumerable<LeaveSallaryType>> GetAllAsync();
        Task<IEnumerable<LeaveSallaryType>> GetAllDeletedAsync();
        Task<LeaveSallaryType> GetByIdAsync(long id);
        Task<LeaveSallaryType> AddAsync(LeaveSallaryType model);
        Task<bool> UpdateAsync(LeaveSallaryType model);
        Task<bool> SoftDeleteAsync(LeaveSallaryType model);
        Task<bool> RestoreAsync(LeaveSallaryType model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(LeaveSallaryType model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<LeaveSallaryType>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<LeaveSallaryType>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
