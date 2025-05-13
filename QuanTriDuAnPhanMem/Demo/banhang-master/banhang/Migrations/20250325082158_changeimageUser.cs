using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class changeimageUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df00d748-8776-4bb0-8267-6aaf50a38ed1");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "District", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "Province", "SecurityStamp", "TwoFactorEnabled", "UserName", "Ward" },
                values: new object[] { "11111111-1111-1111-1111-111111111111", 0, "b15a0c5f-a740-4e14-9e6f-363b7eada42f", "Quận 1", "admin@example.com", true, "Administrator", "Nam", false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAEKJ+rtgAEioxrSDuDY8bmsMGeCIo+C0p+VvhIQ1UgNMqxHOtngrijiBfiH2sx/8LHg==", null, false, "uploads/default.png", "Hồ Chí Minh", "c510a04b-9295-4889-b047-6bead658a8a2", false, "admin", "Phường Bến Nghé" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "District", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "Province", "SecurityStamp", "TwoFactorEnabled", "UserName", "Ward" },
                values: new object[] { "df00d748-8776-4bb0-8267-6aaf50a38ed1", 0, "caa7524a-3e44-4bbc-a3c1-fd55228cca90", "Quận 1", "admin@example.com", true, "Administrator", "Nam", false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAEH+ZndNBNKoz9+YYMouGi6nq/oGsLqzojWBcBNUpwpYwNY5frU14sAcSANoX54zPCg==", null, false, "uploads/default.png", "Hồ Chí Minh", "cfaeca21-a332-4649-9295-f17b29d68700", false, "admin", "Phường Bến Nghé" });
        }
    }
}
