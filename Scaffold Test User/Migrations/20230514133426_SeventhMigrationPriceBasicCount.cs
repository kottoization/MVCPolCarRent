using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class SeventhMigrationPriceBasicCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "469f8f6c-3c63-418d-bc02-1e650c5565c4", "7fef987c-3afb-47d1-a05b-a2e4c19ee8b3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "469f8f6c-3c63-418d-bc02-1e650c5565c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fef987c-3afb-47d1-a05b-a2e4c19ee8b3");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Reservations",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "469f8f6c-3c63-418d-bc02-1e650c5565c4", "3368b21b-d18a-4e64-b9f8-5027fc210435", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "7fef987c-3afb-47d1-a05b-a2e4c19ee8b3", 0, "d722ac56-ab7d-452a-a450-169b4f9c5840", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIKfeeiCh3jw7tA9XwRqeTgJ/yHFKlS5Krq0QFPSfUMkLkjg2fTAfAbQ5qlVkoEUcw==", null, false, "bb801374-7dd2-4f61-8c9e-c5835a6dcb92", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "469f8f6c-3c63-418d-bc02-1e650c5565c4", "7fef987c-3afb-47d1-a05b-a2e4c19ee8b3" });
        }
    }
}
