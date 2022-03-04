using Desk.Core.Common;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Core
{
    public partial class Department : BaseEntity
    {
        public Department()
        {
            Designations = new HashSet<Designation>();
            Employees = new HashSet<Employee>();
        }
        public string Name { get; set; }
        public virtual ICollection<Designation> Designations { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeementTerm> EmployeementTerms { get; set; }
    }
}
