using Desk.Core.Common;
using Desk.Core.Domain.Clients;
using Desk.Core.Domain.Company;
using Desk.Core.Domain.Employees;
using Desk.Core.Domain.Recruitments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Core
{
    public partial class State : BaseEntity
    {
        public State()
        {
            Cities = new HashSet<City>();
            Employees = new HashSet<Employee>();
            Clients = new HashSet<Client>();
            CompanyBranches = new HashSet<CompanyBranch>();
            CompanyContactInformations = new HashSet<CompanyContactInformation>();
            ContactInformations = new HashSet<ContactInformation>();
        }
        public string Name { get; set; }
        public long CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<CompanyBranch> CompanyBranches { get; set; }
        public virtual ICollection<CompanyContactInformation> CompanyContactInformations { get; set; }
        public virtual ICollection<ContactInformation> ContactInformations { get; set; }

    }
}
