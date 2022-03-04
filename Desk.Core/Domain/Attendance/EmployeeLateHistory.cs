using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Attendance
{
    public partial class EmployeeLateHistory:BaseEntity
    {
        public DateTime LateOn { get; set; }
        public int LateInMinutes { get; set; }
        public long EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
