using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Notice
{
    public partial class NoticeItem : BaseEntity
    {
        public NoticeItem()
        {
            NoticeForEmployees = new HashSet<NoticeForEmployee>();
        }
        public string NoticeTitle { get; set; }
        public string NoticeContents { get; set; }
        public virtual ICollection<NoticeForEmployee> NoticeForEmployees { get; set; }
    }
}
