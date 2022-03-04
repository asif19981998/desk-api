
using Desk.Core.Domain.Auth;
using Desk.Core.Domain.Core;
using Desk.Infrastructure.Data;
using Desk.Services.Attendance.EmployeeAtttendances;
using Desk.Services.Auth;
using Desk.Services.Auth.Authentication;
using Desk.Services.Auth.JwtService;
using Desk.Services.Auth.Login;
using Desk.Services.Clients.Clients.Model;
using Desk.Services.Auth.Authentication;
//using Desk.Services.Company.CompanyInformations;
//using Desk.Services.Core.Cities;
using Desk.Services.Core.Countries;
//using Desk.Services.Core.Departments;
//using Desk.Services.Core.Designations;
//using Desk.Services.Core.SiteSettings;
//using Desk.Services.Core.States;
//using Desk.Services.DutyShift_Schedules.EmployeeWorkSchedules;
//using Desk.Services.DutyShift_Schedules.WeekDaysShifts;
//using Desk.Services.DutyShift_Schedules.WorkShifts;
//using Desk.Services.Employees.EmployeeDocuments;
//using Desk.Services.Employees.EmployeeDocumentTypes;
using Desk.Services.Employees.Employees;
//using Desk.Services.Notices.NoticeForEmployees;
//using Desk.Services.Notices.NoticeItems;
//using Desk.Services.Recruitments.Applications;
//using Desk.Services.Recruitments.InterviewSchedules;
//using Desk.Services.Recruitments.JobCirculars;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Desk.Services.Core.States;
using Desk.Services.Core.Cities;
using Desk.Services.Core.Departments;
using Desk.Services.Core.Designations;
using Desk.Services.DutyShift_Schedules.EmployeeWorkSchedules;
using Desk.Services.DutyShift_Schedules.WeekDaysShifts;
using Desk.Services.Employees.EmployeeDocuments;
using Desk.Services.DutyShift_Schedules.WorkShifts;
using Desk.Services.Employees.EmployeeDocumentTypes;
using Desk.Services.Notices.NoticeForEmployees;
using Desk.Services.Recruitments.Applications;
using Desk.Services.Recruitments.JobCirculars;
using Desk.Services.Notices.NoticeItems;
using Desk.Services.Recruitments.InterviewSchedules;
using Desk.Services.Clients.Clients;
using Desk.Services.Company.CompanyInformations;
using Desk.Services.Employees.ContactInformations;
using Desk.Services.Core.JobStatuses;
using Desk.Services.Core.Nationalities;
using Desk.Services.Core.Religions;
using Desk.Services.Core.SiteSettings;
using Desk.Core.Domain.Company;
using Desk.Services.Company.CompanyBranchs;
using Desk.Infrastructure.SqlExtensions.SqlSequence;
using Desk.Services.Employees.EmployeementTerms;
using Desk.Services.Payments.PaymentMethods;
using Desk.Services.Payments.MobileBankAccounts;
using Desk.Services.Payments.BankAccounts;
using Desk.Services.Employees.EmployeePaymentOptions;
using Desk.Services.Employees.EmployeeSalaries;

namespace Desk.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IEmployeeAttendanceService, EmployeeAttendanceService>();
            //services.AddTransient<ISiteSettingService, SiteSettingService>();
            services.AddTransient<ICompanyInformationService, CompanyInformationService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IDesignationService, DesignationService>();
            services.AddTransient<IStateService, StateService>();
            services.AddTransient<IEmployeeWorkScheduleService, EmployeeWorkScheduleService>();
            services.AddTransient<IWeekDaysShiftService, WeekDaysShiftService>();
            services.AddTransient<IWorkShiftService, WorkShiftService>();
            services.AddTransient<IEmployeeDocumentService, EmployeeDocumentService>();
            services.AddTransient<IEmployeeDocumentTypeService, EmployeeDocumentTypeService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<INoticeForEmployeeService, NoticeForEmployeeService>();
            services.AddTransient<IApplicationService, ApplicationService>();
            services.AddTransient<IJobCircularService, JobCircularService>();
            services.AddTransient<INoticeItemService, NoticeItemService>();
            services.AddTransient<IInterviewScheduleService, InterviewScheduleService>();
            services.AddTransient<IAuthenticationService, Auth.Authentication.AuthenticationService>();
            services.AddTransient<IJwtService, JwtService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IContactInformationService, ContactInformationService>();
            services.AddTransient<IJobStatusService, JobStatusService>();
            services.AddTransient<IReligionService, ReligionService>();
            services.AddTransient<INationalityService, NationalityService>();
            services.AddTransient<ISiteSettingService, SiteSettingService>();
            services.AddTransient<ICompanyBranchService, CompanyBranchService>();
            services.AddTransient<IEmployeementTermService, EmployeementTermService>();
            services.AddTransient<ISqlSequenceService, SqlSequenceService>();
            services.AddTransient<IPaymentMethodService, PaymentMethodService>();
            services.AddTransient<IMobileBankAccountService, MobileBankAccountService>();
            services.AddTransient<IBankAccountService, BankAccountService>();
            services.AddTransient<IEmployeePaymentOptionService, EmployeePaymentOptionService>();
            services.AddTransient<IFamilySevice,FamilyService>();
            services.AddTransient<IEmployeeSalaryService, EmployeeSalaryService>();



            return services;
        }
    }
}
