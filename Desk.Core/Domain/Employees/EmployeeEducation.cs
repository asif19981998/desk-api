using Desk.Core.Common;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class EmployeeEducation : BaseEntity
    {
        public long EmployeeId { get; set; }
        public string Institute { get; set; }
        public string FieldOfStudy { get; set; }
        public string Degree { get; set; }
        public int Fromyear { get; set; }
        public int Toyear { get; set; }
        public long AttachmentId { get; set; }
        public string Description { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual MediaFile Attachment { get; set; }
    }
}
