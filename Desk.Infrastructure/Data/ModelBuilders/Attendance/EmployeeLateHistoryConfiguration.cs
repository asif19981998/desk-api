using Desk.Core.Domain.Attendance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.Attendance
{
    public class EmployeeLateHistoryConfiguration : IEntityTypeConfiguration<EmployeeLateHistory>
    {
        public void Configure(EntityTypeBuilder<EmployeeLateHistory> builder)
        {
            builder.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeLateHistories)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
