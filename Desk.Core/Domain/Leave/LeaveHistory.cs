using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Leave
{
   public partial class LeaveHistory:BaseEntity
    {
        public long LeaveApplicationId { get; set; }
        public long LeaveSalaryTypeId { get; set; }
        public virtual LeaveApplication LeaveApplication { get; set; }
        public virtual LeaveSallaryType LeaveSallaryType { get; set; }
    }
}
