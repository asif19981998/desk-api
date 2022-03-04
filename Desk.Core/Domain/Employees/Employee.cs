using Desk.Core.Common;
using Desk.Core.Domain.Attendance;
using Desk.Core.Domain.Company;
using Desk.Core.Domain.Core;
using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Core.Domain.Leave;
using Desk.Core.Domain.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Employees
{
    public partial class Employee : BaseEntity
    {
        public Employee()
        {
            EmployeeDocuments = new HashSet<EmployeeDocument>();
            EmployeeWorkSchedules = new HashSet<EmployeeWorkSchedule>();
            NoticeForEmployees = new HashSet<NoticeForEmployee>();
            EmployeeAttendances = new HashSet<EmployeeAttendance>();
            LeaveApplications = new HashSet<LeaveApplication>();
            EmployeeLateHistories = new HashSet<EmployeeLateHistory>();
            ContactInformations = new HashSet<ContactInformation>();
            EmployeeEducations = new HashSet<EmployeeEducation>();
            EmployeeExperiences = new HashSet<EmployeeExperience>();
        }
        public string ApplicationUserId { get; set; }
        public string FirstName { get; set; }
        public string EmployeeViewId { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine { get; set; }
        
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public long DesignationId { get; set; }
        public long DepartmentId { get; set; }
        public long BranchId { get; set; }
        public virtual CompanyBranch CompanyBranch { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
        public virtual ICollection<EmployeeWorkSchedule> EmployeeWorkSchedules { get; set; }
        public virtual ICollection<NoticeForEmployee> NoticeForEmployees { get; set; }
        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }
        public virtual ICollection<EmployeeAttendance> EmployeeAttendances { get; set; }
        public virtual ICollection<EmployeeLateHistory> EmployeeLateHistories { get; set; }
        public virtual ICollection<ContactInformation> ContactInformations { get; set; }
        public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; }
        public virtual ICollection<EmployeeExperience> EmployeeExperiences { get; set; }
        public virtual ICollection<EmployeementTerm> EmployeementTerms { get; set; }
        public virtual ICollection<EmployeePaymentOption> EmployeePaymentOptions { get; set; }
        public virtual ICollection<EmployeeSalary> EmployeeSalaries { get; set; }
        public virtual ICollection<Family> Families { get; set; }
        public virtual ICollection<OtherInformation> OtherInformations { get; set; }
        public virtual ICollection<TrainingInformation> TrainingInformation { get; set; }
        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }

}

