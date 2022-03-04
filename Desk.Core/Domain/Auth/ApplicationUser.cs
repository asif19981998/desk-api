using Desk.Core.Domain.Media;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            LoginHistories = new HashSet<LoginHistory>();
            UserLogs = new HashSet<UserLog>();
        }
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        public long ProfileImageId { get; set; }

        public virtual ICollection<LoginHistory> LoginHistories { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
    }
}
