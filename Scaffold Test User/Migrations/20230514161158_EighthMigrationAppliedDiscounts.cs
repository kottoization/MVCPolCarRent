using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class EighthMigrationAppliedDiscounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "705c6584-482f-45d9-8a46-5f373f6eb196", "2f450b6b-1073-4eca-8295-84665d58d1b8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "705c6584-482f-45d9-8a46-5f373f6eb196");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f450b6b-1073-4eca-8295-84665d58d1b8");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48f51e4c-7ed8-4609-9184-16359d2306fd", "437afbcd-f73c-4dc3-b2f5-5342cccc21cf", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "160e46bf-7420-48cf-bcee-be838e865a03", 0, "444aa5d1-eefe-4673-a6bc-3b5d39139bb3", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO4Qs5qsTs8SwfTtM1USDV/Wz4+wzyFcHtZXkKMTf8g793hNFzVmx8lv0AkW568AAg==", null, false, "19d9fa30-0147-49da-8f50-6dd108438691", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48f51e4c-7ed8-4609-9184-16359d2306fd", "160e46bf-7420-48cf-bcee-be838e865a03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48f51e4c-7ed8-4609-9184-16359d2306fd", "160e46bf-7420-48cf-bcee-be838e865a03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48f51e4c-7ed8-4609-9184-16359d2306fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160e46bf-7420-48cf-bcee-be838e865a03");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "705c6584-482f-45d9-8a46-5f373f6eb196", "6b455b5f-5202-4ee1-8066-9b45dea3f617", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "2f450b6b-1073-4eca-8295-84665d58d1b8", 0, "e00b3521-d7d4-41d0-8970-6a5020119378", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMLRD2hN/yk0ttBljv65GfOyQ8X14SsZTnu2V6Q5yfWachjjw+PnvP4NRz3yWBPZ+A==", null, false, "a27a3515-636a-4e57-893c-ae05e491ba18", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "705c6584-482f-45d9-8a46-5f373f6eb196", "2f450b6b-1073-4eca-8295-84665d58d1b8" });
        }
    }
}
