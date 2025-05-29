using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83101db-2176-468d-8e52-bd1caee2ac37", "AQAAAAIAAYagAAAAEMJYJS3SMLMnpSB9QykHnlYnjMNOKPVn+lC3sgsnJQNE6DW9zA92NwKVZ6CNCELRWg==", "fa7794af-5295-43f7-ba07-66d710780ea4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc3dd17-2c9e-4398-9df0-bb9636b599b0", "AQAAAAIAAYagAAAAEIuDXRdfUNzfx4RAXClUFTkuOhrjiUWLgvOs6ceu1ygYDLm6ncQic+j9aBZkTy3d/w==", "00bde44c-78ef-40d3-9b38-3897e03691be" });
        }
    }
}
