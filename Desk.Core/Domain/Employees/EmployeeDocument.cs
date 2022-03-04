using Desk.Core.Common;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class EmployeeDocument : BaseEntity
    {
        public long EmployeeId { get; set; }
        public long DocumentFileId { get; set; }
        public long DocumentTypeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual MediaFile MediaFile { get; set; } 
        public virtual EmployeeDocumentType EmployeeDocumentType { get; set; }
    }
}
