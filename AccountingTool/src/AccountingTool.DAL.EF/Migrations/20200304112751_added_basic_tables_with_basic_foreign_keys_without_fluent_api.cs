using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingTool.DAL.EF.Migrations
{
    public partial class added_basic_tables_with_basic_foreign_keys_without_fluent_api : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesSize",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Size = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClothesTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WearSizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WearSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WearTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WearTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SeasonId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ClothesTypeId = table.Column<Guid>(nullable: false),
                    ClothesSizeId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_ClothesSize_ClothesSizeId",
                        column: x => x.ClothesSizeId,
                        principalTable: "ClothesSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clothes_ClothesTypes_ClothesTypeId",
                        column: x => x.ClothesTypeId,
                        principalTable: "ClothesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clothes_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemAccountings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateOfIssue = table.Column<DateTime>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAccountings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAccountings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wears",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    WearTypeId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    WearSizeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wears_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wears_WearSizes_WearSizeId",
                        column: x => x.WearSizeId,
                        principalTable: "WearSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wears_WearTypes_WearTypeId",
                        column: x => x.WearTypeId,
                        principalTable: "WearTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ClothesSizeId",
                table: "Clothes",
                column: "ClothesSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ClothesTypeId",
                table: "Clothes",
                column: "ClothesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ItemId",
                table: "Clothes",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAccountings_ItemId",
                table: "ItemAccountings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SeasonId",
                table: "Items",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Wears_ItemId",
                table: "Wears",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Wears_WearSizeId",
                table: "Wears",
                column: "WearSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wears_WearTypeId",
                table: "Wears",
                column: "WearTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "ItemAccountings");

            migrationBuilder.DropTable(
                name: "Wears");

            migrationBuilder.DropTable(
                name: "ClothesSize");

            migrationBuilder.DropTable(
                name: "ClothesTypes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "WearSizes");

            migrationBuilder.DropTable(
                name: "WearTypes");

            migrationBuilder.DropTable(
                name: "Season");
        }
    }
}
