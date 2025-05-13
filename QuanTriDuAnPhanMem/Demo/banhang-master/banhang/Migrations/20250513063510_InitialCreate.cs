using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dddbd65-825c-4acd-aa1a-91ff44e7db1d", "AQAAAAIAAYagAAAAEDv8j7qwH9wj3ZiP9jhicGqp+htAdqYkRyMJY7Wp4nc4MScwdvzfnYVuwinA9WbWig==", "ac6fd370-1fd5-42c8-b68d-45ac2e0e9fb5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "895ed93b-8245-482d-9697-21f4f47fb5e6", "AQAAAAIAAYagAAAAEEPmUasxcrkK683M3F9/s1hMZ4Xdr5opIBGKeSmiaslIMHwHJWBiFQjcsXbsDfl6Ww==", "a0b53558-6f5a-47dc-bfe6-73afc235dde6" });
        }
    }
}
