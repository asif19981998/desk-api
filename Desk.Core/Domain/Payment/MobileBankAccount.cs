using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Payment
{
    public partial class MobileBankAccount : BaseEntity
    {
        public string Code { get; set; }
        public string ProviderName { get; set; }
        public string AccountNumber { get; set; }
        public string Website { get; set; }
        public virtual ICollection<EmployeePaymentOption> EmployeePaymentOptions { get; set; }
    }
}
