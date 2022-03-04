using Desk.Core.Domain.Recruitments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.Infrastructure.Data.ModelBuilders.Recruitments
{
    class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> entity)
        {
            entity.HasOne(d => d.JobCircular)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.CircularId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Photograph)
                  .WithMany(p => p.ApplicationPhotographs)
                  .HasForeignKey(d => d.PhotographId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Resume)
                  .WithMany(p => p.ApplicationResumes)
                  .HasForeignKey(d => d.ResumeId)
                  .OnDelete(DeleteBehavior.ClientSetNull);


        }
    }
}

