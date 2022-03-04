using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Core.Enums
{
    public enum ApplicationStatus
    {
        New = 1,
        Pending = 2,
        ResumeRejected = 3,
        AgreedToInterview = 4,
        PendingResult = 5,
        Accepted = 6,
        Rejected = 7,
        Appointed = 8
    }
}
