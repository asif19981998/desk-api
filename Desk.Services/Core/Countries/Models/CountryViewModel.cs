using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Countries.Models
{
     public class CountryViewModel:BaseEntity
    {
        public string name { get; set; }
       
        public int StateCount { set; get; }
        public int EmployeeCount { get; set; }
        public int ClientCount { get; set; }
        public int CompanyContactInformationCount { get; set; }
        public int ContactInformationCount { get; set; }
        

    }
}
