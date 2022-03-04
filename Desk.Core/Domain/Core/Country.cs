using Desk.Core.Common;
using Desk.Core.Domain.Clients;
using Desk.Core.Domain.Company;
using Desk.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Core
{
    public partial class Country : BaseEntity
    {
        public Country()
        {
            States = new HashSet<State>();
            Employees = new HashSet<Employee>();
            Clients = new HashSet<Client>();
            CompanyBranches = new HashSet<CompanyBranch>();
            CompanyContactInformations = new HashSet<CompanyContactInformation>();
            ContactInformations = new HashSet<ContactInformation>();
        }
        public string Name { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<CompanyBranch> CompanyBranches { get; set; }
        public virtual ICollection<CompanyContactInformation> CompanyContactInformations { get; set; }
        public virtual ICollection<ContactInformation> ContactInformations { get; set; }

    }
}
