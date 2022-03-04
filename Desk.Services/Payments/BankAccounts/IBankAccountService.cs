using Desk.Core.Domain.Payment;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Payments.BankAccounts
{
    public interface IBankAccountService
    {
        Task<IEnumerable<BankAccount>> GetAllAsync();
        Task<IEnumerable<BankAccount>> GetAllDeletedAsync();
        Task<BankAccount> GetByIdAsync(long id);
        Task<BankAccount> AddAsync(BankAccount model);
        Task<bool> UpdateAsync(BankAccount model);
        Task<bool> SoftDeleteAsync(BankAccount model);
        Task<bool> RestoreAsync(BankAccount model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(BankAccount model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<BankAccount>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<BankAccount>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
