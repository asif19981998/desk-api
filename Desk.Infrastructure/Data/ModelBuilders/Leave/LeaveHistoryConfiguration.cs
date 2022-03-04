using Desk.Core.Domain.Leave;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.Leave
{
    public class LeaveHistoryConfiguration: IEntityTypeConfiguration<LeaveHistory>
    {
        public void Configure(EntityTypeBuilder<LeaveHistory> entity)
        {
            entity.HasOne(d => d.LeaveApplication)
                    .WithMany(p => p.LeaveHistories)
                    .HasForeignKey(d => d.LeaveApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.LeaveSallaryType)
                   .WithMany(p => p.LeaveHistories)
                   .HasForeignKey(d => d.LeaveSalaryTypeId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
