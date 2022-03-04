using Desk.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Domain.Attendance
{
   public partial class HolidayDate:BaseEntity
    {
        public string Name { get; set; }
        public DateTime OnDate { get; set; }
        public string Description { get; set; }
        public long HolidayId { get; set; }
        public virtual Holiday Holiday { get; set; }

    }
}
