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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasOne(d => d.Country)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(d => d.StateId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.City)
                  .WithMany(p => p.Employees)
                  .HasForeignKey(d => d.CityId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Designation)
                  .WithMany(p => p.Employees)
                  .HasForeignKey(d => d.DesignationId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
           
            entity.HasOne(d => d.Department)
                  .WithMany(p => p.Employees)
                  .HasForeignKey(d => d.DepartmentId)
                  .OnDelete(DeleteBehavior.ClientSetNull);


            entity.HasOne(d => d.CompanyBranch)
                  .WithMany(p => p.Employees)
                  .HasForeignKey(d => d.BranchId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

