using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Cities
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllAsync();
        Task<IEnumerable<City>> GetAllDeletedAsync();
        Task<City> GetByIdAsync(long id);
        Task<City> AddAsync(City model);
        Task<bool> UpdateAsync(City model);
        Task<bool> SoftDeleteAsync(City model);
        Task<bool> RestoreAsync(City model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(City model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<City>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<City>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
