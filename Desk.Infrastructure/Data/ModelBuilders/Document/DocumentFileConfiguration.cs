using Desk.Core.Domain.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Data.ModelBuilders.DutyShift_Schedules
{
    public class DocumentFileConfiguration:IEntityTypeConfiguration<DocumentFile>
    {
        public void Configure(EntityTypeBuilder<DocumentFile> entity)
        {
            entity.HasOne(d => d.MediaFile)
                .WithMany(p => p.DocumentFiles)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
