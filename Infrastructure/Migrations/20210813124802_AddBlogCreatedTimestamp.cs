using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddBlogCreatedTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8e9af46c-274d-4773-877f-628af6068151"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "PortfolioItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumTel",
                table: "Owner",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "Email", "FullName", "NumTel", "Profil" },
                values: new object[] { new Guid("141cbe6a-4120-488c-b63e-09cf1cf45f3c"), null, "avatar.jpg", "engazzouazer1@gmail.com", "Azer Engazzou", "29701169", "Student" });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioItems_CategoryId",
                table: "PortfolioItems",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioItems_Category_CategoryId",
                table: "PortfolioItems",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioItems_Category_CategoryId",
                table: "PortfolioItems");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioItems_CategoryId",
                table: "PortfolioItems");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("141cbe6a-4120-488c-b63e-09cf1cf45f3c"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PortfolioItems");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "NumTel",
                table: "Owner");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("8e9af46c-274d-4773-877f-628af6068151"), null, "avatar.jpg", "Azer Engazzou", "Student" });
        }
    }
}
