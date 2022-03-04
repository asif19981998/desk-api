using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Leave
{
    public partial class LeaveSallaryType : BaseEntity
    {
        public LeaveSallaryType()
        {
            LeaveHistories = new HashSet<LeaveHistory>();
        }
        public string LeaveTypeName { get; set; }
        public decimal Persent { get; set; }
        public virtual ICollection<LeaveHistory> LeaveHistories { get; set; }

    }
}
