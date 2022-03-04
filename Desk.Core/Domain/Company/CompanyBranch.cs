using Desk.Core.Common;
using Desk.Core.Domain.Core;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Company
{
    public partial class CompanyBranch : BaseEntity
    {
        public CompanyBranch()
        {
            Employees = new HashSet<Employee>();
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public long StateId { get; set; }
        public long CountryId { get; set; }
        public string PhoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string PostalCode { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeementTerm> EmployeementTerms { get; set; }
    }
}
