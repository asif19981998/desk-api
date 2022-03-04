using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
   public partial class EmployeeDocumentType:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
    }
}
