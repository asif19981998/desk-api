using Desk.Core.Domain.DutyShift_Schedules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.DutyShift_Schedules
{
    public class WeekDaysShiftConfiguration : IEntityTypeConfiguration<WeekDaysShift>
    {
        public void Configure(EntityTypeBuilder<WeekDaysShift> entity)
        {
            entity.HasOne(d => d.WorkShift)
                    .WithMany(p => p.WeekDaysShifts)
                    .HasForeignKey(d => d.WorkShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}

