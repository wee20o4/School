using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class adddayReturn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnOrderDate",
                table: "ReturnOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb4d9104-bcc4-4a98-b8c7-14b3dfa080c7", "AQAAAAIAAYagAAAAELEJ1ChbEcNy9L5lU6RT2xiQos9wULhEzU9qz5CXXDZtXw5wddlA8sIDZZ1fhDiPyA==", "e733306f-6706-40d4-9e34-9148e1407e8b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnOrderDate",
                table: "ReturnOrders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15a0c5f-a740-4e14-9e6f-363b7eada42f", "AQAAAAIAAYagAAAAEKJ+rtgAEioxrSDuDY8bmsMGeCIo+C0p+VvhIQ1UgNMqxHOtngrijiBfiH2sx/8LHg==", "c510a04b-9295-4889-b047-6bead658a8a2" });
        }
    }
}
