using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Core
{
    public partial class Designation : BaseEntity
    {
        public Designation()
        {
            Employees = new HashSet<Employee>();
        }
        public string Name { get; set; }
        public long DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeementTerm> EmployeementTerms { get; set; }
    }
}
