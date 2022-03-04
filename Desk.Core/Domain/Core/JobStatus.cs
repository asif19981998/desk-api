using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Core
{
    public partial class JobStatus : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<EmployeementTerm> EmployeementTerms { get; set; }
    }
}
