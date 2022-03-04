using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Notice
{
    public partial class NoticeForEmployee : BaseEntity
    {
        public long NoticeItemId { get; set; }
        public long EmployeeId { get; set; }
        public virtual NoticeItem NoticeItem { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
