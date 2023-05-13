using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class SixthMigrationStartAndFinishSetAsRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "979ec07c-81af-4f39-9cff-05a8ab7543e2", "77dfc004-e5f0-4eb4-9607-4ceee885ffc4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "979ec07c-81af-4f39-9cff-05a8ab7543e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77dfc004-e5f0-4eb4-9607-4ceee885ffc4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "979ec07c-81af-4f39-9cff-05a8ab7543e2", "62e40e0e-9a10-4be9-abbe-a516643d9731", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "77dfc004-e5f0-4eb4-9607-4ceee885ffc4", 0, "49b07eb3-8ec3-49f5-94a0-b36ec9d43dda", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF+9BMrADPd95gC61eNJgIzPYwmSvLrCiyAtgID95V5JijfKyUtFGBCeLOnoPR+zAQ==", null, false, "fa32952c-03e6-4427-bbdd-3e3540dedc4b", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "979ec07c-81af-4f39-9cff-05a8ab7543e2", "77dfc004-e5f0-4eb4-9607-4ceee885ffc4" });
        }
    }
}
