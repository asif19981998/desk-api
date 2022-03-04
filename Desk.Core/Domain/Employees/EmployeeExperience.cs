using Desk.Core.Common;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class EmployeeExperience : BaseEntity
    {
        public long EmployeeId { get; set; }
        public string Employeer { get; set; }
        public string JobTitle { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Salary { get; set; }
        public long AttachmentId { get; set; }
        public string Description { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual MediaFile Attachment { get; set; }
    }
}
