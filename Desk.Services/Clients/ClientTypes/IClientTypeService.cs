using Desk.Core.Domain.Clients;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Clients.ClientTypes
{
    public interface IClientTypeService
    {
        Task<IEnumerable<ClientType>> GetAllAsync();
        Task<IEnumerable<ClientType>> GetAllDeletedAsync();
        Task<ClientType> GetByIdAsync(long id);
        Task<ClientType> AddAsync(ClientType model);
        Task<bool> UpdateAsync(ClientType model);
        Task<bool> SoftDeleteAsync(ClientType model);
        Task<bool> RestoreAsync(ClientType model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(ClientType model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<ClientType>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<ClientType>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
