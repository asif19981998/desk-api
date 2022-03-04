using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.DutyShift_Schedules
{
    public partial class WeekDaysShift:BaseEntity
    {
        public DayOfWeek DayOfWeek { get; set; }
        public bool IsOffDay { get; set; } = false;
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int BreakStartHour { get; set; }
        public int BreakEndMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
        public long WorkShiftId { get; set; }
        public virtual WorkShift WorkShift { get; set; }
    }
}
