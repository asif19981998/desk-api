using Desk.Core.Common;
using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
   public partial class Family:BaseEntity
    {
        public long EmployeeId { get; set; }
        public MaritualStatus MaritualStatus { get; set; }
        public int FamilyMember { get; set; }
        public int Children { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
