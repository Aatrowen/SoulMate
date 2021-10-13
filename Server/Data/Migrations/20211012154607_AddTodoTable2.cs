using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulMate.Server.Migrations
{
    public partial class AddTodoTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c78ee7a-9ad0-415a-939e-98c9bc793dc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3ac3891-55db-43b7-bc47-28d2a026c347");

            migrationBuilder.AddColumn<DateTime>(
                name: "TodoDate",
                table: "TodoItems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37df3fe0-8a0f-4b7f-b1ce-282d404ae693", "325635b5-74c2-40b3-8ccf-262c2f5d1ca3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4333a27-54e7-4467-a169-e8300534790f", "536f1c25-9e5e-41f0-868a-1f22044ea9d8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37df3fe0-8a0f-4b7f-b1ce-282d404ae693");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4333a27-54e7-4467-a169-e8300534790f");

            migrationBuilder.DropColumn(
                name: "TodoDate",
                table: "TodoItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3ac3891-55db-43b7-bc47-28d2a026c347", "6a2d8c17-260b-4c13-a5ce-ed298d8960e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c78ee7a-9ad0-415a-939e-98c9bc793dc9", "e38f14c8-c4d1-4212-b11c-c5e7f7b9ad53", "User", "USER" });
        }
    }
}
