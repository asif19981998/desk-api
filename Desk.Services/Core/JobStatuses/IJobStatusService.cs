using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.JobStatuses
{
   public interface IJobStatusService
    {
        Task<IEnumerable<JobStatus>> GetAllAsync();
        Task<IEnumerable<JobStatus>> GetAllDeletedAsync();
        Task<JobStatus> GetByIdAsync(long id);
        Task<JobStatus> AddAsync(JobStatus model);
        Task<bool> UpdateAsync(JobStatus model);
        Task<bool> SoftDeleteAsync(JobStatus model);
        Task<bool> RestoreAsync(JobStatus model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(JobStatus model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<JobStatus>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<JobStatus>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
