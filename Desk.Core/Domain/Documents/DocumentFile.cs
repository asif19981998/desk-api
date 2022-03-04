using Desk.Core.Common;
using Desk.Core.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Documents
{
  public partial  class DocumentFile:BaseEntity
    {
        public long MediaId { get; set; }
        public virtual MediaFile MediaFile  { get; set; } /// eita zip file ta dekhe thik koren vai
    }
}
