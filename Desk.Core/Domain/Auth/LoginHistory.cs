using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Auth
{
   public class LoginHistory:BaseEntity
    {
        public string IpAddress { get; set; }
        public string DeviceMAC { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
