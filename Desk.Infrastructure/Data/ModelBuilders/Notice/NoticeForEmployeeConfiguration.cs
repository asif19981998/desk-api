using Desk.Core.Domain.Notice;
using Desk.Core.Domain.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.Infrastructure.Data.ModelBuilders.Notice
{
    public class NoticeForEmployeeConfiguration : IEntityTypeConfiguration<NoticeForEmployee>
    {
        public void Configure(EntityTypeBuilder<NoticeForEmployee> entity)
        {
            entity.HasOne(d => d.NoticeItem)
                    .WithMany(p => p.NoticeForEmployees)
                    .HasForeignKey(d => d.NoticeItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.NoticeForEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
