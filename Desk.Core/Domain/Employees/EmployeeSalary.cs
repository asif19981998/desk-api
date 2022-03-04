using Desk.Core.Common;
using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
   public partial class EmployeeSalary:BaseEntity
    {
        public long EmployeeId { get; set; }
        public decimal BaseSalary { get; set; }
        public DateTime NewReviewDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public PaymentPeriod PaymentPeriod { get; set; }
        public bool IsPerformanceBonusEnabled { get; set; }
        public decimal PerformanceBonus { get; set; }
        public bool IsAttendanceBonusEnabled { get; set; }
        public decimal AttendanceBonus { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
