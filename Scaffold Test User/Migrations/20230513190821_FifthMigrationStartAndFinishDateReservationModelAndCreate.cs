using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_Test_User.Migrations
{
    public partial class FifthMigrationStartAndFinishDateReservationModelAndCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Finish",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d108d48f-1b36-4d73-855f-bb6acf8e2814", "3b76bd13-7f94-4858-9028-c7d9d5033cfc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "reservationCount" },
                values: new object[] { "59c7b65a-ff9e-48f7-bff9-9369d88d8929", 0, "6f5dd6b3-2942-444b-9a3d-389313e18bb1", "admin@example.com", false, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP460kBuKsaMp2ctDVoy1voJcQtYqSSO6tl1NfZlIbYjOU+SiCPw6qy8t7lxNcRT1g==", null, false, "b86a2f77-3eae-4069-b0f1-2117b987b13f", false, "admin@example.com", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d108d48f-1b36-4d73-855f-bb6acf8e2814", "59c7b65a-ff9e-48f7-bff9-9369d88d8929" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d108d48f-1b36-4d73-855f-bb6acf8e2814", "59c7b65a-ff9e-48f7-bff9-9369d88d8929" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d108d48f-1b36-4d73-855f-bb6acf8e2814");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c7b65a-ff9e-48f7-bff9-9369d88d8929");

            migrationBuilder.DropColumn(
                name: "Finish",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDays",
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
    }
}
