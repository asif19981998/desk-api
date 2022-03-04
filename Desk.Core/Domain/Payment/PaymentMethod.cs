using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Payment
{
    public partial class PaymentMethod : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<EmployeePaymentOption> EmployeePaymentOptions { get; set; }
    }
}
