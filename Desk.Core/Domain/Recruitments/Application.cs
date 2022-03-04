using Desk.Core.Common;
using Desk.Core.Domain.Media;
using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Recruitments
{
    public partial class Application : BaseEntity
    {
        public string CandidateFullName { get; set; }
        public string Email { get; set; }
        public string ShortDescription { get; set; }
        public long PhotographId { get; set; }
        public long ResumeId { get; set; }
        public long CircularId { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; }
        public virtual JobCircular JobCircular { get; set; }
        public virtual MediaFile Photograph { get; set; }
        public virtual MediaFile Resume { get; set; }
    }
}
