using Desk.Core.Common;
using Desk.Core.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class ContactInformation : BaseEntity
    {
        public long EmployeeId { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Whatsapp { get; set; }
        public string Linkedin { get; set; }
        public string OfficePhone { get; set; }
        public string PersonalPhone { get; set; }
        public string HomePhone { get; set; }
        public string AddressLine { get; set; }
        public long CityId { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public string PostalCode { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string RelationShip { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
