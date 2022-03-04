using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.States
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetAllAsync();
        Task<IEnumerable<State>> GetAllDeletedAsync();
        Task<State> GetByIdAsync(long id);
        Task<State> AddAsync(State model);
        Task<bool> UpdateAsync(State model);
        Task<bool> SoftDeleteAsync(State model);
        Task<bool> RestoreAsync(State model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(State model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<State>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<State>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
