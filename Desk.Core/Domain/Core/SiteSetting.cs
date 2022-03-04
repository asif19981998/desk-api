using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Core
{
    public partial class SiteSetting : BaseEntity
    {
        public string SiteName { get; set; }
        public bool IsPortFolioEnabled { get; set; }
        public bool IsRecruitmentEnable { get; set; }
        public bool IsRealTimeChatEnable { get; set; }
        public bool IsTaskManagementEnable { get; set; }
        public bool IsTakeAttendanceByLogin { get; set; }
    }
}
