using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DeskContext>
    {
        public DeskContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DeskContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-EKTIBRB\\SQLEXPRESS01;Database=Deskdb;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new DeskContext(optionsBuilder.Options);
        }
    }
}
