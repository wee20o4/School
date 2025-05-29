using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentitySetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9feca399-9342-444d-a718-5656b9f3e5fc", "AQAAAAIAAYagAAAAEBEAcqjikVvSx3j+iN4turx0xK9luKEE2C57lcnmphnFVi/7WxJVqbI3d6LnlpnmcQ==", "f30106af-6c12-4897-a14c-2e1213253b91" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f4302d-e25d-4348-a2cd-779e170b3a98", "AQAAAAIAAYagAAAAEKhFLC3PugDnafrElFZleuoVamvh/AjMRgm1f1dZi3+MB1H1VW70os2UZRHa4ASexw==", "52e0dc87-0951-40a9-999d-30c8b369488f" });
        }
    }
}
