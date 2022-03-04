using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Employees.Employees.Model
{
    public class EmployeeVM:BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeViewId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public long DesignationId { get; set; }
        public long DepartmentId { get; set; }
        public long BranchId { get; set; }
    }
}
