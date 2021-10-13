using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulMate.Server.Migrations
{
    public partial class AddTodoTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37df3fe0-8a0f-4b7f-b1ce-282d404ae693");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4333a27-54e7-4467-a169-e8300534790f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "986a52a1-71d8-4117-b1d7-bf552c78eb94", "2ac73a8a-7b8f-4634-8db2-0c6dc7d28efc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe19f879-c7a2-4c20-b2c8-85ae12c0dcbc", "306f4ef7-7fab-410c-b969-48b0e0ffbbc6", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "986a52a1-71d8-4117-b1d7-bf552c78eb94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe19f879-c7a2-4c20-b2c8-85ae12c0dcbc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37df3fe0-8a0f-4b7f-b1ce-282d404ae693", "325635b5-74c2-40b3-8ccf-262c2f5d1ca3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4333a27-54e7-4467-a169-e8300534790f", "536f1c25-9e5e-41f0-868a-1f22044ea9d8", "User", "USER" });
        }
    }
}
