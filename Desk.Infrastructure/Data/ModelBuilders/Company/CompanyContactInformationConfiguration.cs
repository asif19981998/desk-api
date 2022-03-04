using Desk.Core.Domain.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.Company
{
    class CompanyContactInformationConfiguration : IEntityTypeConfiguration<CompanyContactInformation>
    {
        public void Configure(EntityTypeBuilder<CompanyContactInformation> entity)
        {
            entity.HasOne(d => d.City)
                    .WithMany(p => p.CompanyContactInformations)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Country)
                  .WithMany(p => p.CompanyContactInformations)
                  .HasForeignKey(d => d.CountryId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State)
                  .WithMany(p => p.CompanyContactInformations)
                  .HasForeignKey(d => d.StateId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}