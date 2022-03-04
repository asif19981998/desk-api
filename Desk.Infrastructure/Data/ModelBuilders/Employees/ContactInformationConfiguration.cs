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
    public class ContactInformationConfiguration:IEntityTypeConfiguration<ContactInformation>
    {
        public void Configure(EntityTypeBuilder<ContactInformation> entity)
      {
            entity.HasOne(d => d.Employee)
                   .WithMany(p => p.ContactInformations)
                   .HasForeignKey(d => d.EmployeeId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.City)
                   .WithMany(p => p.ContactInformations)
                   .HasForeignKey(d => d.CityId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.Country)
                   .WithMany(p => p.ContactInformations)
                   .HasForeignKey(d => d.CountryId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.State)
                   .WithMany(p => p.ContactInformations)
                   .HasForeignKey(d => d.StateId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
