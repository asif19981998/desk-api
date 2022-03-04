using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public  class OtherInformation : BaseEntity
    {
        public long EmployeeId { get; set; }
        public string Remarks { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
