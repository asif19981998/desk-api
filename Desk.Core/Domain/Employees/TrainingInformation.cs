using Desk.Core.Common;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public class TrainingInformation : BaseEntity
    {
        public long EmployeeId { get; set; }

        public string Institute { get; set; }
        public string Course { get; set; }
        public string Trainer { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long AttachmentId { get; set; }
        public string Description { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual MediaFile Attachment { get; set; }

    }
}
