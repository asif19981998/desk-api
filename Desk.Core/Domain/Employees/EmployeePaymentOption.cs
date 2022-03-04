using Desk.Core.Common;
using Desk.Core.Domain.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class EmployeePaymentOption : BaseEntity
    {
        public long EmployeeId { get; set; }
        public long PaymentMethodId { get; set; }
        public long BankAccountId { get; set; }
        public long MobileBankId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual MobileBankAccount MobileBankAccount { get; set; }
    }
}
