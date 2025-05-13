using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class fixacc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b8eb9c1-5c9f-42e5-9c9e-b2939582f412");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aff6f959-7c3f-4228-8235-43861c6a6d22", 0, "decf9cc3-6154-45c4-8002-1951ab911fbf", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAEEKJo3/pFGUZ453O35Y02OQVMULT+XENLisBNAhmOpqHaswNpaVMIcty399DeyTUIw==", null, false, "73e1e45e-1eab-4b4c-ae5d-3f276b5100af", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aff6f959-7c3f-4228-8235-43861c6a6d22");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b8eb9c1-5c9f-42e5-9c9e-b2939582f412", 0, "b9cdff3e-5fed-4ad1-ad05-acd9cf54ac90", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAENj5PEUweS1NrihQ6GMUlL1mxW4zEPb4SIEVAeWdTEeV0di6pCSvAbVnU4s/7CLYOw==", null, false, "0995d5e0-b04d-4017-994d-76321fc9d8a0", false, "admin" });
        }
    }
}
