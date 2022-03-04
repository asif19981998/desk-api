using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using Desk.Services.Core.Countries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Countries
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllAsync();
        public  Task<List<CountryViewModel>> GetAllDataAsync();
        Task<IEnumerable<Country>> GetAllDeletedAsync();
        Task<Country> GetByIdAsync(long id);
        Task<Country> AddAsync(Country model);
        Task<bool> UpdateAsync(Country model);
        Task<bool> SoftDeleteAsync(Country model);
        Task<bool> MultipleRowPermanentDelete(int[] ids);
        Task<bool> RestoreAsync(Country model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Country model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Country>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Country>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
