using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Religions
{
    public interface IReligionService
    {
        Task<IEnumerable<Religion>> GetAllAsync();
        Task<IEnumerable<Religion>> GetAllDeletedAsync();
        Task<Religion> GetByIdAsync(long id);
        Task<Religion> AddAsync(Religion model);
        Task<bool> UpdateAsync(Religion model);
        Task<bool> SoftDeleteAsync(Religion model);
        Task<bool> RestoreAsync(Religion model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Religion model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Religion>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Religion>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
