using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CreateSec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("6fdcde62-ff9c-4440-9cd0-e27240321a4c"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("8e9af46c-274d-4773-877f-628af6068151"), null, "avatar.jpg", "Azer Engazzou", "Student" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8e9af46c-274d-4773-877f-628af6068151"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("6fdcde62-ff9c-4440-9cd0-e27240321a4c"), null, "avatar.jpg", "Khalid ESSAADANI", "Microsoft MVP / .NET Consultant" });
        }
    }
}
