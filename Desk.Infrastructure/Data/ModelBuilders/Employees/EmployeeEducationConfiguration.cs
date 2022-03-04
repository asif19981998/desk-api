using Desk.Core.Domain.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.Employees
{
    public class EmployeeEducationConfiguration : IEntityTypeConfiguration<EmployeeEducation>
    {
        public void Configure(EntityTypeBuilder<EmployeeEducation> entity)
        {
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeEducations)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Attachment)
                 .WithMany(p => p.EmployeeEducations)
                 .HasForeignKey(d => d.AttachmentId)
                 .OnDelete(DeleteBehavior.ClientSetNull);


        }
    }
}
