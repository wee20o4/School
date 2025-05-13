using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class AddReturnOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b813e5-4a1d-43d6-8049-3b86930b4aeb");

            migrationBuilder.AddColumn<string>(
                   name: "NewId",
                   table: "Users",
                   type: "nvarchar(450)",
                   nullable: false,
                   defaultValue: "");

            migrationBuilder.Sql("UPDATE Users SET NewId = CAST(Id AS NVARCHAR(450))"); // Copy dữ liệu cũ sang

            migrationBuilder.DropPrimaryKey("PK_Users", "Users");

            migrationBuilder.DropColumn("Id", "Users"); // Xóa cột cũ

            migrationBuilder.RenameColumn("NewId", "Users", "Id"); // Đổi tên cột mới thành Id

            migrationBuilder.AddPrimaryKey("PK_Users", "Users", "Id");
            migrationBuilder.AddColumn<bool>(
                name: "RememberMe",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ReturnOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalRefund = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_ReturnOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RefundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetails_ReturnOrders_ReturnOrderId",
                        column: x => x.ReturnOrderId,
                        principalTable: "ReturnOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b8eb9c1-5c9f-42e5-9c9e-b2939582f412", 0, "b9cdff3e-5fed-4ad1-ad05-acd9cf54ac90", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAENj5PEUweS1NrihQ6GMUlL1mxW4zEPb4SIEVAeWdTEeV0di6pCSvAbVnU4s/7CLYOw==", null, false, "0995d5e0-b04d-4017-994d-76321fc9d8a0", false, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetails_ProductId",
                table: "ReturnOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetails_ReturnOrderId",
                table: "ReturnOrderDetails",
                column: "ReturnOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrders_CustomerId",
                table: "ReturnOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrders_OrderId",
                table: "ReturnOrders",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnOrderDetails");

            migrationBuilder.DropTable(
                name: "ReturnOrders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b8eb9c1-5c9f-42e5-9c9e-b2939582f412");

            migrationBuilder.DropColumn(
                name: "RememberMe",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f0b813e5-4a1d-43d6-8049-3b86930b4aeb", 0, "f6dedd17-b6b2-485d-984e-3bcb0c435b8f", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Administrator", "AQAAAAIAAYagAAAAEP0kirRXpNpBbUN7Jje7MkScX/w9NM4o282CclTp8EOUmXAGAFQolFT60i/C2mvRWw==", null, false, "6b577a86-13cc-46c1-82d8-1d1cb2005838", false, "admin" });
        }
    }
}
