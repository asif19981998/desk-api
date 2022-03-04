using Desk.Core.Domain.Clients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.Clients
{

    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entity)
        {
            entity.HasOne(d => d.Country)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State)
                   .WithMany(p => p.Clients)
                   .HasForeignKey(d => d.StateId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.City)
                  .WithMany(p => p.Clients)
                  .HasForeignKey(d => d.CityId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ClientType)
                  .WithMany(p => p.Clients)
                  .HasForeignKey(d => d.ClientTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }

}
