using Desk.Core.Domain.Recruitments;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Recruitments.InterviewSchedules
{
   public interface IInterviewScheduleService
    {
        Task<IEnumerable<InterviewSchedule>> GetAllAsync();
        Task<IEnumerable<InterviewSchedule>> GetAllDeletedAsync();
        Task<InterviewSchedule> GetByIdAsync(long id);
        Task<InterviewSchedule> AddAsync(InterviewSchedule model);
        Task<bool> UpdateAsync(InterviewSchedule model);
        Task<bool> SoftDeleteAsync(InterviewSchedule model);
        Task<bool> RestoreAsync(InterviewSchedule model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(InterviewSchedule model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<InterviewSchedule>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<InterviewSchedule>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
