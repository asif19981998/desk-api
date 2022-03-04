using Desk.Core.Common;
using Desk.Core.Domain.Core;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Clients
{
    public partial class Client : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long ClientLogo { get; set; }
        public string PhoneNumber { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public string AddressLine { get; set; }
        public long ClientTypeId { get; set; }
        public virtual ClientType ClientType { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
        public virtual MediaFile Media { get; set; }        
    }
}
