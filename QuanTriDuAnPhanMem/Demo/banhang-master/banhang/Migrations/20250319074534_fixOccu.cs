using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class fixOccu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bbe113c-9c77-4e8f-8f8e-897c5faee83a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f0b813e5-4a1d-43d6-8049-3b86930b4aeb", 0, "f6dedd17-b6b2-485d-984e-3bcb0c435b8f", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAEP0kirRXpNpBbUN7Jje7MkScX/w9NM4o282CclTp8EOUmXAGAFQolFT60i/C2mvRWw==", null, false, "6b577a86-13cc-46c1-82d8-1d1cb2005838", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b813e5-4a1d-43d6-8049-3b86930b4aeb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1bbe113c-9c77-4e8f-8f8e-897c5faee83a", 0, "ee002663-82dd-4e82-9c31-7e64014bd3b7", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAEB+AyPAVjekL1+WZmtOKrapZx44VPgPg2vTUfEvJ02KGGpEcgObKJ9BsQ6wDIW5UXQ==", null, false, "c5a1e5d8-cf75-423a-bd76-89ab8f93d324", false, "admin" });
        }
    }
}
