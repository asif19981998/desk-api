using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Payment
{
   public partial class BankAccount:BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string ContactNumber { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<EmployeePaymentOption> EmployeePaymentOptions { get; set; }
    }
}
