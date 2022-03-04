using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Auth
{
    public partial class RolePermission : BaseEntity
    {
        public string RoleId { get; set; }
        public long PermissionId { get; set; }

        public Permission Permission { get; set; }
    }
}
