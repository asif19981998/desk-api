using Desk.Core.Domain.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.Auth
{
   public class LoginHistoryConfiguration : IEntityTypeConfiguration<LoginHistory>
    {
     
        public void Configure(EntityTypeBuilder<LoginHistory> builder)
        {
            builder.HasOne(d => d.ApplicationUser)
                .WithMany(p => p.LoginHistories)
                .HasForeignKey(d => d.ApplicationUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
