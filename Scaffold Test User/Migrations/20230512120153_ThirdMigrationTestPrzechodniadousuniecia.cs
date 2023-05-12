using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class ThirdMigrationTestPrzechodniadousuniecia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a10759b-e783-491a-a7e6-f055ed4563f0", "baf0c4a9-54a7-4e47-8825-be16f7749ad7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a10759b-e783-491a-a7e6-f055ed4563f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf0c4a9-54a7-4e47-8825-be16f7749ad7");

            migrationBuilder.AddColumn<int>(
                name: "reservationCount",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ef1f9fe-6c3a-456d-b0f2-26afdab87b8b", "9faa15a6-66a8-4b21-8475-767025c30821", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "039f2e79-648c-417c-a478-a005bbebb505", 0, "65f78328-56c3-4543-8a39-c8101685149a", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBEPN6C2b0GXPSWbP+Q9c7p5xGmyCLz6SEPmOpsWGYmLMKtxVRJj4CvYuyHwpX5iVw==", null, false, "104e751c-ea54-40ec-8f17-01c41e50f3b1", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ef1f9fe-6c3a-456d-b0f2-26afdab87b8b", "039f2e79-648c-417c-a478-a005bbebb505" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ef1f9fe-6c3a-456d-b0f2-26afdab87b8b", "039f2e79-648c-417c-a478-a005bbebb505" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ef1f9fe-6c3a-456d-b0f2-26afdab87b8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "039f2e79-648c-417c-a478-a005bbebb505");

            migrationBuilder.DropColumn(
                name: "reservationCount",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a10759b-e783-491a-a7e6-f055ed4563f0", "96169819-123d-4bd1-af91-6e8cf3caca00", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "baf0c4a9-54a7-4e47-8825-be16f7749ad7", 0, "11d7752a-f32a-4a08-93e0-9460f8937d6e", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMDgdMsBt2kUvIw/U3P3Dhh+t2D9mhSYhtpvU6dIhQdSmF+JW6WSv8nOraejq+9xxA==", null, false, "f23c97c6-840a-43c3-ad0c-794f8fa4bfc0", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a10759b-e783-491a-a7e6-f055ed4563f0", "baf0c4a9-54a7-4e47-8825-be16f7749ad7" });
        }
    }
}
