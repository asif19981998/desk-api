using Desk.Core.Domain.Recruitments;
using Desk.Core.Miscellaneous;
using Desk.Services.Recruitments.Applications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Recruitments.Applications
{
   public interface IApplicationService
    {
        Task<IEnumerable<Application>> GetAllAsync();
        Task<IEnumerable<Application>> GetAllDeletedAsync();
        Task<Application> GetByIdAsync(long id);
        Task<Application> AddAsync(Application model);
        Task<ApplicationStatusModel> GetApplicationStatusById(long id);
        Task<bool> UpdateAsync(Application model);
        Task<bool> SoftDeleteAsync(Application model);
        Task<bool> RestoreAsync(Application model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(Application model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<Application>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<Application>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
