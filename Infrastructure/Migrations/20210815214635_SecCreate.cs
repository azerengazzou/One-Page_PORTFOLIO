using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SecCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("141cbe6a-4120-488c-b63e-09cf1cf45f3c"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategId",
                table: "PortfolioItems",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "Email", "FullName", "NumTel", "Profil" },
                values: new object[] { new Guid("c351ff9c-c1bf-4d30-b83e-d2320602a6e9"), null, "avatar.jpg", "engazzouazer1@gmail.com", "Azer Engazzou", "29701169", "Student" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("c351ff9c-c1bf-4d30-b83e-d2320602a6e9"));

            migrationBuilder.DropColumn(
                name: "CategId",
                table: "PortfolioItems");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "Email", "FullName", "NumTel", "Profil" },
                values: new object[] { new Guid("141cbe6a-4120-488c-b63e-09cf1cf45f3c"), null, "avatar.jpg", "engazzouazer1@gmail.com", "Azer Engazzou", "29701169", "Student" });
        }
    }
}
