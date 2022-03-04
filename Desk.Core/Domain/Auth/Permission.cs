using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Auth
{
    public partial class Permission : BaseEntity
    {
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }
        public string Name { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
