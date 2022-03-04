using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Recruitments
{
    public partial class JobCircular : BaseEntity
    {
        public JobCircular()
        {
            Applications = new HashSet<Application>();
        }

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string EducationalRequirements { get; set; }
        public string TechnicalRequirements { get; set; }
        public string JobResponsibilities { get; set; }
        public string ExperienceRequirements { get; set; }
        public int Vacancy { get; set; } = 0;
        public bool IsVacancyNotSpecified { get; set; } = false;
        public string SalaryAndCompensation { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
