using Desk.Core.Domain.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.Infrastructure.Data.SeedData
{
    public static class SeedData
    {

        public static void SeedDatas(ModelBuilder builder)
        {

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "5f72f83b-7436-4221-869c-1b69b2e23aae",
                    PhoneNumber = "01234567",
                    Email = "system@admin.com",
                    EmailConfirmed = false,
                    FirstName = "System",
                    LockoutEnabled = false,
                    NormalizedEmail = "SYSTEM@ADMIN.COM",
                    NormalizedUserName = "SYSTEM@ADMIN.COM",
                    PasswordHash = "AQAAAAEAACcQAAAAEIDO3+uDv45LuwqNpSoRWkU0BZNs3K0sHR7ErNqB/qlZGEnQiOrudCJuWtGI42AfbQ==",
                    ConcurrencyStamp = "9abe9d5e-4917-4cd9-9b7c-97f7a9871e09",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "a9565acb-cee6-425f-9833-419a793f5fba",
                    TwoFactorEnabled = false,
                    UserName = "system@admin.com"
                });
        }
    }

}
