using Desk.Core.Common;
using Desk.Core.Domain.Auth;
using Desk.Core.Domain.Clients;
using Desk.Core.Domain.Company;
using Desk.Core.Domain.Documents;
using Desk.Core.Domain.Employees;
using Desk.Core.Domain.Recruitments;
using Desk.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Media
{
    public partial class MediaFile : BaseEntity
    {
        public MediaFile()
        {
            EmployeeDocuments = new HashSet<EmployeeDocument>();
            DocumentFiles = new HashSet<DocumentFile>();
            Clients = new HashSet<Client>();
            CompanyInformations = new HashSet<CompanyInformation>();
            EmployeeEducations = new HashSet<EmployeeEducation>();
            EmployeeExperiences = new HashSet<EmployeeExperience>();
            ApplicationResumes = new HashSet<Application>();
            ApplicationPhotographs = new HashSet<Application>();
        }
       
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public MediaType MediaType { get; set; }
        public long FileSize { get; set; }
        public virtual ICollection<DocumentFile> DocumentFiles { get; set; }
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<CompanyInformation> CompanyInformations { get; set; }
        public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; }
        public virtual ICollection<EmployeeExperience> EmployeeExperiences { get; set; }
        public virtual ICollection<TrainingInformation> TrainingInformation { get; set; }
        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }

        public virtual ICollection<Application> ApplicationResumes { get; set; }
        public virtual ICollection<Application> ApplicationPhotographs { get; set; }

       
    }
}
