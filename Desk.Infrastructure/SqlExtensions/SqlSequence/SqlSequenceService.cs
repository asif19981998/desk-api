using Desk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.SqlExtensions.SqlSequence
{
    public class SqlSequenceService:ISqlSequenceService
    {
        private DeskContext context;
        public SqlSequenceService(DeskContext context)
        {
            this.context = context;
        }
         public int GetEmployeeSequence()
        {
            return context.GetEmployeeSequence();
        }
    }
}
