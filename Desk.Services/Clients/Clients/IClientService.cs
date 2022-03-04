using Desk.Core.Domain.Clients;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Clients.Clients
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<IEnumerable<Client>> GetAllDeletedAsync();
        Task<Client> GetByIdAsync(long id);
        Task<Client> AddAsync(Client model);
        Task<bool> UpdateAsync(Client model);
        Task<bool> SoftDeleteAsync(Client model);
        Task<bool> RestoreAsync(Client model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Client model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Client>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Client>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
