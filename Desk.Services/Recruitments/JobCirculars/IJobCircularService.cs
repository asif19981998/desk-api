using Desk.Core.Domain.Recruitments;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Recruitments.JobCirculars
{
    public interface IJobCircularService
    {
        Task<IEnumerable<JobCircular>> GetAllAsync();
        Task<IEnumerable<JobCircular>> GetAllDeletedAsync();
        Task<JobCircular> GetByIdAsync(long id);
        Task<JobCircular> AddAsync(JobCircular model);
        Task<bool> UpdateAsync(JobCircular model);
        Task<bool> SoftDeleteAsync(JobCircular model);
        Task<bool> RestoreAsync(JobCircular model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(JobCircular model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<JobCircular>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<JobCircular>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
