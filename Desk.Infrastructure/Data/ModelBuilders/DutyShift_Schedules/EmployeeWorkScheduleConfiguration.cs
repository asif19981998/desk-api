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
    public class EmployeeWorkScheduleConfiguration:IEntityTypeConfiguration<EmployeeWorkSchedule>
    {
        public void Configure(EntityTypeBuilder<EmployeeWorkSchedule> entity)
        {
            entity.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeWorkSchedules)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.WorkShift)
                .WithMany(p => p.EmployeeWorkSchedules)
                .HasForeignKey(d => d.WorkShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            
            entity.HasOne(d => d.Holiday)
                .WithMany(p => p.EmployeeWorkSchedules)
                .HasForeignKey(d => d.HolidayId)
                .OnDelete(DeleteBehavior.ClientSetNull);



        }
    }
}
