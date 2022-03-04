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
    public class EmployeePaymentOptionConfiguration : IEntityTypeConfiguration<EmployeePaymentOption>
    {
        public void Configure(EntityTypeBuilder<EmployeePaymentOption> entity)
        {
            entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePaymentOptions)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PaymentMethod)
                 .WithMany(p => p.EmployeePaymentOptions)
                 .HasForeignKey(d => d.PaymentMethodId)
                 .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.BankAccount)
               .WithMany(p => p.EmployeePaymentOptions)
               .HasForeignKey(d => d.BankAccountId)
               .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.MobileBankAccount)
               .WithMany(p => p.EmployeePaymentOptions)
               .HasForeignKey(d => d.MobileBankId)
               .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
