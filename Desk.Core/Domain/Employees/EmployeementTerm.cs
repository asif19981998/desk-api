using Desk.Core.Common;
using Desk.Core.Domain.Company;
using Desk.Core.Domain.Core;
using Desk.Core.Domain.DutyShift_Schedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class EmployeementTerm : BaseEntity
    {
        public long EmployeeId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime TermStartDate { get; set; }
        public DateTime TermEndDate { get; set; }
        public long DesignationId { get; set; }
        public long JobStatusId { get; set; }
        public long WorkShiftId { get; set; }
        public long DepartmentId { get; set; }
        public long BranchId { get; set; }
        public bool IsInProbation { get; set; }
        public DateTime ProbationPeriodEnd { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual JobStatus JobStatus { get; set; }
        public virtual WorkShift WorkShift { get; set; }
        public virtual Department Department { get; set; }
        public virtual CompanyBranch CompanyBranch { get; set; }
    }
}
