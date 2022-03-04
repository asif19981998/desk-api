using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Leave
{
    public partial class LeaveApplication : BaseEntity
    {
        public LeaveApplication()
        {
            LeaveHistories = new HashSet<LeaveHistory>();
        }
        public long EmployeeId { get; set; }
        public string LeaveReason { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public LeaveApplicationStatus LeaveApplicationStatus { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<LeaveHistory> LeaveHistories { get; set; }
    }
}
