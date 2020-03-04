using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingTool.DAL.EF.Migrations
{
    public partial class addedrelationsitemAccountingwithEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "ItemAccountings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemAccountings_EmployeeId",
                table: "ItemAccountings",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAccountings_Employees_EmployeeId",
                table: "ItemAccountings",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAccountings_Employees_EmployeeId",
                table: "ItemAccountings");

            migrationBuilder.DropIndex(
                name: "IX_ItemAccountings_EmployeeId",
                table: "ItemAccountings");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ItemAccountings");
        }
    }
}
