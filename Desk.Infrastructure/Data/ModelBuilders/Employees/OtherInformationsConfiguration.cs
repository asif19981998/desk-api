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
    public class OtherInformationsConfiguration : IEntityTypeConfiguration<OtherInformation>
    {
        public void Configure(EntityTypeBuilder<OtherInformation> entity)
        {
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.OtherInformations)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}