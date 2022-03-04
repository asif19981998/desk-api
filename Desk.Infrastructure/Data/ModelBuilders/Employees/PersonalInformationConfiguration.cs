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
    public class PersonalInformationConfiguration : IEntityTypeConfiguration<PersonalInformation>
    {
        public void Configure(EntityTypeBuilder<PersonalInformation> entity)
        {
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PersonalInformations)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasOne(d => d.Religion)
                   .WithMany(p => p.PersonalInformations)
                   .HasForeignKey(d => d.ReligionId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasOne(d => d.Nationality)
                   .WithMany(p => p.PersonalInformations)
                   .HasForeignKey(d => d.NationalityId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
