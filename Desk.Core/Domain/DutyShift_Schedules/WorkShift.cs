using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.DutyShift_Schedules
{
   public partial class WorkShift:BaseEntity
    {
        public WorkShift()
        {
            WeekDaysShifts = new HashSet<WeekDaysShift>();
            EmployeeWorkSchedules = new HashSet<EmployeeWorkSchedule>();
        }
        public string   WorkShiftName { get; set; }
        public string Description { get; set; }
        public int MaximumNumberOfOffDay { get; set; }
        public virtual ICollection<WeekDaysShift> WeekDaysShifts { get; set; }
        public virtual ICollection<EmployeeWorkSchedule> EmployeeWorkSchedules { get; set; }
        public virtual ICollection<EmployeementTerm> EmployeementTerms { get; set; }
    }
}
