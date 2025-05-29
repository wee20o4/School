using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class InitWithIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc3dd17-2c9e-4398-9df0-bb9636b599b0", "AQAAAAIAAYagAAAAEIuDXRdfUNzfx4RAXClUFTkuOhrjiUWLgvOs6ceu1ygYDLm6ncQic+j9aBZkTy3d/w==", "00bde44c-78ef-40d3-9b38-3897e03691be" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9feca399-9342-444d-a718-5656b9f3e5fc", "AQAAAAIAAYagAAAAEBEAcqjikVvSx3j+iN4turx0xK9luKEE2C57lcnmphnFVi/7WxJVqbI3d6LnlpnmcQ==", "f30106af-6c12-4897-a14c-2e1213253b91" });
        }
    }
}
