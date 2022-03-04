using Desk.Core.Common;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Company
{
    public partial class CompanyInformation : BaseEntity
    {
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string RegistrationNumber { get; set; }
        public long LogoId { get; set; }
        public virtual  MediaFile  Logo{ get; set; }
    }
}
