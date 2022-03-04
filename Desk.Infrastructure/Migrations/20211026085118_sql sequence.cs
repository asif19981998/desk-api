using Microsoft.EntityFrameworkCore.Migrations;

namespace Desk.Infrastructure.Migrations
{
    public partial class sqlsequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PasswordConfirm",
                table: "Employee");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateSequence(
                name: "emp_seq",
                schema: "dbo",
                startValue: 10000L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "emp_seq",
                schema: "dbo");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirm",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
