using Desk.Core.Domain.Payment;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Payments.MobileBankAccounts
{
   public interface IMobileBankAccountService
    {
        Task<IEnumerable<MobileBankAccount>> GetAllAsync();
        Task<IEnumerable<MobileBankAccount>> GetAllDeletedAsync();
        Task<MobileBankAccount> GetByIdAsync(long id);
        Task<MobileBankAccount> AddAsync(MobileBankAccount model);
        Task<bool> UpdateAsync(MobileBankAccount model);
        Task<bool> SoftDeleteAsync(MobileBankAccount model);
        Task<bool> RestoreAsync(MobileBankAccount model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(MobileBankAccount model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<MobileBankAccount>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<MobileBankAccount>> GetDeletedPagedAsync(int page, int pageSize);

    }
}
