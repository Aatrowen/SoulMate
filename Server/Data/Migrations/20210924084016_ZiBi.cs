using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulMate.Server.Migrations
{
    public partial class ZiBi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "4b60e98a-1bb6-4c5b-bb38-5189f0aea03a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000000", "f8a9adf3-2a4c-448c-8c4b-0413608e0953", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0b678ef-e787-45cd-ab23-f011d44a5786", "AQAAAAEAACcQAAAAEA5iZd3vo/XbfujaVA7TnxLAbMG3wdvZaQR8WOsQ4kat+TwDDKi3aKm/s7epShecwg==", "716eeb11-c49e-48cc-bfc3-09c9b7fb4495" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "7bca6dea-f024-4d3a-af21-5c610f1c0417");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ec42d23-b947-43b5-b541-819a17fea34a", "AQAAAAEAACcQAAAAEE3k52Ew/VvUnQrs/VM+aPuZCU/crbDzyIPdDgI2EMJdWuR3FTtVTvFKVkIhVvtUDg==", "dd8cbc6c-bcca-4adb-ab25-9892ab155526" });
        }
    }
}
