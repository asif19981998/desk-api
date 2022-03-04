using Desk.Core.Common;
using Desk.Core.Domain.Attendance;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.DutyShift_Schedules
{
    public partial class EmployeeWorkSchedule : BaseEntity
    {
        public long EmployeeId { get; set; }
        public long WorkShiftId { get; set; }
        public long HolidayId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual WorkShift WorkShift { get; set; }
        public virtual Holiday Holiday { get; set; }


    }
}
