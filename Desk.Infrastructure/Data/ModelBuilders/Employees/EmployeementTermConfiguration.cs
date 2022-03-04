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
    public class EmployeementTermConfiguration : IEntityTypeConfiguration<EmployeementTerm>
    {
        public void Configure(EntityTypeBuilder<EmployeementTerm> entity)
        {
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeementTerms)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Designation)
                 .WithMany(p => p.EmployeementTerms)
                 .HasForeignKey(d => d.DesignationId)
                 .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.JobStatus)
                 .WithMany(p => p.EmployeementTerms)
                 .HasForeignKey(d => d.JobStatusId)
                 .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WorkShift)
                 .WithMany(p => p.EmployeementTerms)
                 .HasForeignKey(d => d.WorkShiftId)
                 .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.Department)
                 .WithMany(p => p.EmployeementTerms)
                 .HasForeignKey(d => d.DepartmentId)
                 .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.CompanyBranch)
                 .WithMany(p => p.EmployeementTerms)
                 .HasForeignKey(d => d.BranchId)
                 .OnDelete(DeleteBehavior.ClientSetNull);
           


        }
    }
}
