using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Nationalities
{
    public interface INationalityService
    {
        Task<IEnumerable<Nationality>> GetAllAsync();
        Task<IEnumerable<Nationality>> GetAllDeletedAsync();
        Task<Nationality> GetByIdAsync(long id);
        Task<Nationality> AddAsync(Nationality model);
        Task<bool> UpdateAsync(Nationality model);
        Task<bool> SoftDeleteAsync(Nationality model);
        Task<bool> RestoreAsync(Nationality model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Nationality model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Nationality>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Nationality>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
