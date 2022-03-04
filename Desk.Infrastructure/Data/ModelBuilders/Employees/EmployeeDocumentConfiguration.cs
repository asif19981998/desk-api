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
    public class EmployeeDocumentConfiguration : IEntityTypeConfiguration<EmployeeDocument>
    {
        public void Configure(EntityTypeBuilder<EmployeeDocument> entity)
        {
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeDocuments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.MediaFile)
                    .WithMany(p => p.EmployeeDocuments)
                    .HasForeignKey(d => d.DocumentFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.EmployeeDocumentType)
                    .WithMany(p => p.EmployeeDocuments)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
