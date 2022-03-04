
using Desk.Core.Common;
using Desk.Core.Domain.Core;
using Desk.Core.Domain.Media;
using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class PersonalInformation : BaseEntity
    {
        public long EmployeeId { get; set; }

        public long ProfilePictureId { get; set; }
        public long CoverPictureId { get; set; }
        public long NationalityId { get; set; }
        public string PassportNumber { get; set; }
        public Gender Gender { get; set; }
        public long ReligionId { get; set; }
        public string BirthCertificateNumber { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual MediaFile MediaFile { get; set; }
    }
}
