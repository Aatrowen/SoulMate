using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulMate.Server.Migrations
{
    public partial class ZiBiLe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "308660dc-ae51-480f-824d-7dca6714c3e2", "90184155-dee0-40c9-bb1e-b5ed07afc04e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42f97597-eae9-46a4-8713-66a6d075f8a1", "509c9875-2b7c-480b-820f-5e50489c37f5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe5fb917-84dc-4f3f-83a7-2ba5666395b9", "f267af7d-aeab-4281-8a56-a1756d0ff047", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42f97597-eae9-46a4-8713-66a6d075f8a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe5fb917-84dc-4f3f-83a7-2ba5666395b9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "308660dc-ae51-480f-824d-7dca6714c3e2", "4b60e98a-1bb6-4c5b-bb38-5189f0aea03a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000000", "f8a9adf3-2a4c-448c-8c4b-0413608e0953", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RealName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90184155-dee0-40c9-bb1e-b5ed07afc04e", 0, null, 0, "e0b678ef-e787-45cd-ab23-f011d44a5786", "1402210387@qq.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEA5iZd3vo/XbfujaVA7TnxLAbMG3wdvZaQR8WOsQ4kat+TwDDKi3aKm/s7epShecwg==", "19155063202", false, null, "716eeb11-c49e-48cc-bfc3-09c9b7fb4495", false, "Aatrowen" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "308660dc-ae51-480f-824d-7dca6714c3e2", "90184155-dee0-40c9-bb1e-b5ed07afc04e" });
        }
    }
}
