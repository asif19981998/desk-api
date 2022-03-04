using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.SqlExtensions.SqlSequence
{
    public interface ISqlSequenceService
    {
        int GetEmployeeSequence();
    }
}
