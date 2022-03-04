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
    class CompanyBranchConfiguration : IEntityTypeConfiguration<CompanyBranch>
    {
        public void Configure(EntityTypeBuilder<CompanyBranch> entity)
        {
            entity.HasOne(d => d.City)
                    .WithMany(p => p.CompanyBranches)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Country)
                  .WithMany(p => p.CompanyBranches)
                  .HasForeignKey(d => d.CountryId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State)
                  .WithMany(p => p.CompanyBranches)
                  .HasForeignKey(d => d.StateId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
