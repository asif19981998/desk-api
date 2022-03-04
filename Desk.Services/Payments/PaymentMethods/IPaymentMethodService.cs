using Desk.Core.Domain.Payment;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Payments.PaymentMethods
{
   public interface IPaymentMethodService
    {
        Task<IEnumerable<PaymentMethod>> GetAllAsync();
        Task<IEnumerable<PaymentMethod>> GetAllDeletedAsync();
        Task<PaymentMethod> GetByIdAsync(long id);
        Task<PaymentMethod> AddAsync(PaymentMethod model);
        Task<bool> UpdateAsync(PaymentMethod model);
        Task<bool> SoftDeleteAsync(PaymentMethod model);
        Task<bool> RestoreAsync(PaymentMethod model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(PaymentMethod model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<PaymentMethod>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<PaymentMethod>> GetDeletedPagedAsync(int page, int pageSize);

    }
}
