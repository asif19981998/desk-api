
using Desk.Core.Domain.Attendance;
using Desk.Core.Domain.Auth;
using Desk.Core.Domain.Clients;
using Desk.Core.Domain.Company;
using Desk.Core.Domain.Core;
using Desk.Core.Domain.Documents;
using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Core.Domain.Employees;
using Desk.Core.Domain.Leave;
using Desk.Core.Domain.Media;
using Desk.Core.Domain.Notice;
using Desk.Core.Domain.Payment;
using Desk.Core.Domain.Recruitments;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Desk.Infrastructure.Data
{
    public partial class DeskContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {

        public DeskContext(DbContextOptions<DeskContext> options)
            : base(options)
        {
        }
        #region Attendance
        public virtual DbSet<EmployeeAttendance> EmployeeAttendance { get; set; }
        public virtual DbSet<EmployeeLateHistory> EmployeeLateHistory { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<HolidayDate> HolidayDate { get; set; }
        #endregion
        #region Auth
        public virtual DbSet<LoginHistory> LoginHistory { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
       
        #endregion

        #region Client
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        #endregion

        #region Company
        public virtual DbSet<CompanyInformation> CompanyInformation { get; set; }
        public virtual DbSet<CompanyBranch> CompanyBranch { get; set; }
        public virtual DbSet<CompanyContactInformation> CompanyContactInformation { get; set; }
        #endregion
        #region Core
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<JobStatus> JobStatus { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<SiteSetting> SiteSetting { get; set; }
        public virtual DbSet<State> State { get; set; }

        #endregion
        #region Documents
        public virtual DbSet<DocumentFile> DocumentFile { get; set; }

        #endregion
        #region DutyShif_Schedules     
        public virtual DbSet<EmployeeWorkSchedule> EmployeeWorkSchedule { get; set; }
        public virtual DbSet<WeekDaysShift> WeekDaysShift { get; set; }
        public virtual DbSet<WorkShift> WorkShift { get; set; }
        #endregion
        #region Employees
        public virtual DbSet<ContactInformation> ContactInformation { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDocument> EmployeeDocument { get; set; }
        public virtual DbSet<EmployeeDocumentType> EmployeeDocumentType { get; set; }
        public virtual DbSet<EmployeeEducation> EmployeeEducation { get; set; }
        public virtual DbSet<EmployeeExperience> EmployeeExperience { get; set; }
        public virtual DbSet<EmployeementTerm> EmployeementTerm { get; set; }
        public virtual DbSet<EmployeePaymentOption> EmployeePaymentOption { get; set; }
        public virtual DbSet<EmployeeSalary> EmployeeSalary { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<OtherInformation> OtherInformation { get; set; }
        public virtual DbSet<PersonalInformation> PersonalInformation { get; set; }
        public virtual DbSet<TrainingInformation> TrainingInformation { get; set; }

        #endregion
        #region Media
        public virtual DbSet<MediaFile> MediaFile { get; set; }
        #endregion
        #region Notice
        public virtual DbSet<NoticeForEmployee> NoticeForEmployee { get; set; }
        public virtual DbSet<NoticeItem> NoticeItem { get; set; }
        #endregion
        #region Recruitment
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<InterviewSchedule> InterviewSchedule { get; set; }
        public virtual DbSet<JobCircular> JobCircular { get; set; }
        #endregion

        #region Leave
        public virtual DbSet<LeaveApplication> LeaveApplications { get; set; }
        public virtual DbSet<LeaveHistory> LeaveHistories { get; set; }
        public virtual DbSet<LeaveSallaryType> LeaveSallaryTypes { get; set; }
        #endregion
        #region payment
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<MobileBankAccount> MobileBankAccount { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedData.SeedData.SeedDatas(builder);
            builder.HasSequence("emp_seq", schema: "dbo").StartsAt(10000).IncrementsBy(1);
            base.OnModelCreating(builder);
        }

        public int GetEmployeeSequence()
        {

            SqlParameter result = new SqlParameter("@result", System.Data.SqlDbType.Int)
            {
                Direction = System.Data.ParameterDirection.Output
            };

            Database.ExecuteSqlRaw(
                       "SELECT @result = (NEXT VALUE FOR emp_seq)", result);

            return (int)result.Value;
        }


    }
}