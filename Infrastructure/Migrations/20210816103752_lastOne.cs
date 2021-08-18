using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class lastOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("c351ff9c-c1bf-4d30-b83e-d2320602a6e9"));

            migrationBuilder.DropColumn(
                name: "CategId",
                table: "PortfolioItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PortfolioItems");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "Email", "FullName", "NumTel", "Profil" },
                values: new object[] { new Guid("f25c6a75-c330-4f8e-85d2-d818051746a7"), null, "avatar.jpg", "engazzouazer1@gmail.com", "Azer Engazzou", "29701169", "Student" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("f25c6a75-c330-4f8e-85d2-d818051746a7"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategId",
                table: "PortfolioItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "PortfolioItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "Email", "FullName", "NumTel", "Profil" },
                values: new object[] { new Guid("c351ff9c-c1bf-4d30-b83e-d2320602a6e9"), null, "avatar.jpg", "engazzouazer1@gmail.com", "Azer Engazzou", "29701169", "Student" });

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
    }
}
