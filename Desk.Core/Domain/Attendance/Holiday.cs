using Desk.Core.Common;
using Desk.Core.Domain.DutyShift_Schedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Attendance
{
   public partial class Holiday:BaseEntity
    {
        public Holiday()
        {
            HolidayDates = new HashSet<HolidayDate>();
            EmployeeWorkSchedules = new HashSet<EmployeeWorkSchedule>();
        }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public virtual ICollection<HolidayDate> HolidayDates { get; set; }
        public virtual ICollection<EmployeeWorkSchedule> EmployeeWorkSchedules { get; set; }
    }
}
