using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Attendance
{
   public class EmployeeAttendance:BaseEntity
    {
        public long EmployeeId { get; set; }
        public bool IsAbsence { get; set; } = false;
        public DateTime InTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
