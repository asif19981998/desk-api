using Microsoft.EntityFrameworkCore.Migrations;

namespace Desk.Infrastructure.Migrations
{
    public partial class resolvestateIdname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_State_SateId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "SateId",
                table: "Employee",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_SateId",
                table: "Employee",
                newName: "IX_Employee_StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_State_StateId",
                table: "Employee",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_State_StateId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Employee",
                newName: "SateId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_StateId",
                table: "Employee",
                newName: "IX_Employee_SateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_State_SateId",
                table: "Employee",
                column: "SateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
