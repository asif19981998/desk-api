using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Recruitments.Applications.Models
{
   public class ApplicationStatusModel
    {
        public long ApplicationId { get; set; }
        public ApplicationStatus ApplicationStatus{ get; set; }
    }
}
