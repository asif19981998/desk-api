using Desk.Core.Domain.Notice;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Notices.NoticeForEmployees
{
    public interface INoticeForEmployeeService
    {
        Task<IEnumerable<NoticeForEmployee>> GetAllAsync();
        Task<IEnumerable<NoticeForEmployee>> GetAllDeletedAsync();
        Task<NoticeForEmployee> GetByIdAsync(long id);
        Task<NoticeForEmployee> AddAsync(NoticeForEmployee model);
        Task<bool> UpdateAsync(NoticeForEmployee model);
        Task<bool> SoftDeleteAsync(NoticeForEmployee model);
        Task<bool> RestoreAsync(NoticeForEmployee model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(NoticeForEmployee model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<NoticeForEmployee>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<NoticeForEmployee>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
