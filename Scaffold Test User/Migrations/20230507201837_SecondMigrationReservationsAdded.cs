using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class SecondMigrationReservationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5627c9f-190a-4238-ae41-8abf419b917b", "af10c80c-c8be-48fc-a514-0c8669594160" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5627c9f-190a-4238-ae41-8abf419b917b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af10c80c-c8be-48fc-a514-0c8669594160");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5627c9f-190a-4238-ae41-8abf419b917b", "52a92bf8-ab80-4e73-9971-7159a801dea6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "af10c80c-c8be-48fc-a514-0c8669594160", 0, "6d982ca9-07a6-491e-b136-9666c5d6395c", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDRxJ/x069KKauHz/kFsZ1LNvALWHnU5wV6IJ0TREo3LEt+QUzQq7nX4hVol+EkaxA==", null, false, "a11ef366-7351-42b7-8070-72072cfbc42e", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f5627c9f-190a-4238-ae41-8abf419b917b", "af10c80c-c8be-48fc-a514-0c8669594160" });
        }
    }
}
