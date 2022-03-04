using Desk.Core.Domain.Notice;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Notices.NoticeItems
{
    public interface INoticeItemService
    {
        Task<IEnumerable<NoticeItem>> GetAllAsync();
        Task<IEnumerable<NoticeItem>> GetAllDeletedAsync();
        Task<NoticeItem> GetByIdAsync(long id);
        Task<NoticeItem> AddAsync(NoticeItem model);
        Task<bool> UpdateAsync(NoticeItem model);
        Task<bool> SoftDeleteAsync(NoticeItem model);
        Task<bool> RestoreAsync(NoticeItem model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(NoticeItem model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<NoticeItem>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<NoticeItem>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
