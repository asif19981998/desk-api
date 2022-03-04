using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Clients
{
    public partial class ClientType : BaseEntity
    {
        public ClientType()
        {
            Clients = new HashSet<Client>();
        }
        public string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
