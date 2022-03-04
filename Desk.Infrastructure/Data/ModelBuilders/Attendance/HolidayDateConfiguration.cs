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
    public class HolidayDateConfiguration : IEntityTypeConfiguration<HolidayDate>
    {
        public void Configure(EntityTypeBuilder<HolidayDate> builder)
        {
            builder.HasOne(d => d.Holiday)
                .WithMany(p => p.HolidayDates)
                .HasForeignKey(d => d.HolidayId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
