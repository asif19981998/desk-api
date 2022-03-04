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
    class CompanyInformationConfiguration : IEntityTypeConfiguration<CompanyInformation>
    {
        public void Configure(EntityTypeBuilder<CompanyInformation> entity)
        {
            entity.HasOne(d => d.Logo)
                    .WithMany(p => p.CompanyInformations)
                    .HasForeignKey(d => d.LogoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
