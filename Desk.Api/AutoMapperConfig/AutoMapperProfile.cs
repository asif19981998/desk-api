using AutoMapper;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.AutoMapperConfiguration
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeVM, Employee>();
        }


    }
}
