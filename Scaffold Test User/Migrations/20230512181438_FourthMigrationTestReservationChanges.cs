using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class FourthMigrationTestReservationChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDays",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fea80bd4-0e8d-4065-b4ad-72cbc57a293e", "e5068dac-3a53-4198-ab29-66ca6ada2719", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "a573476a-9174-4923-b60b-a5bf10b64a77", 0, "1b4362fc-2a71-4e06-83e4-fcd71ed62fd3", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOEvUsjq52yJoY04cetu1ZnEjE5L/CRejT0+pafzCdkGomvwTjAh1eAxLN9/k5E9tw==", null, false, "bda11abe-9ef7-4ecd-8106-9839b9aeef74", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fea80bd4-0e8d-4065-b4ad-72cbc57a293e", "a573476a-9174-4923-b60b-a5bf10b64a77" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fea80bd4-0e8d-4065-b4ad-72cbc57a293e", "a573476a-9174-4923-b60b-a5bf10b64a77" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fea80bd4-0e8d-4065-b4ad-72cbc57a293e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a573476a-9174-4923-b60b-a5bf10b64a77");

            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Reservations");

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
    }
}
