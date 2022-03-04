using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Leaves.LeaveApplications
{
   public class LeaveApplicationStatusViewModel
    {
        public long EmployeeId { get; set; }
        public LeaveApplicationStatus LeaveApplicationStatus { get; set; }
    }
}
