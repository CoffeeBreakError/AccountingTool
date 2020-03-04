using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingTool.DAL.EF.Migrations
{
    public partial class addwearsizewearheightrenamedwearsizetowearproportion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wears_WearSizes_WearSizeId",
                table: "Wears");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "WearSizes");

            migrationBuilder.CreateTable(
                name: "WearHeights",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Height = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WearHeights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WearProportions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    WearSizeId = table.Column<Guid>(nullable: false),
                    WearHeightId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WearProportions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WearProportions_WearHeights_WearHeightId",
                        column: x => x.WearHeightId,
                        principalTable: "WearHeights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WearProportions_WearSizes_WearSizeId",
                        column: x => x.WearSizeId,
                        principalTable: "WearSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WearProportions_WearHeightId",
                table: "WearProportions",
                column: "WearHeightId");

            migrationBuilder.CreateIndex(
                name: "IX_WearProportions_WearSizeId",
                table: "WearProportions",
                column: "WearSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wears_WearProportions_WearSizeId",
                table: "Wears",
                column: "WearSizeId",
                principalTable: "WearProportions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wears_WearProportions_WearSizeId",
                table: "Wears");

            migrationBuilder.DropTable(
                name: "WearProportions");

            migrationBuilder.DropTable(
                name: "WearHeights");

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "WearSizes",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wears_WearSizes_WearSizeId",
                table: "Wears",
                column: "WearSizeId",
                principalTable: "WearSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
