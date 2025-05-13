using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrdersDetails_Products_ProductId",
                table: "PurchaseOrdersDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrdersDetails_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrdersDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrdersDetails_Suppliers_SupplierId",
                table: "PurchaseOrdersDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseOrdersDetails",
                table: "PurchaseOrdersDetails");

            migrationBuilder.RenameTable(
                name: "PurchaseOrdersDetails",
                newName: "PurchaseOrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrdersDetails_SupplierId",
                table: "PurchaseOrderDetails",
                newName: "IX_PurchaseOrderDetails_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrdersDetails_PurchaseOrderId",
                table: "PurchaseOrderDetails",
                newName: "IX_PurchaseOrderDetails_PurchaseOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrdersDetails_ProductId",
                table: "PurchaseOrderDetails",
                newName: "IX_PurchaseOrderDetails_ProductId");

            migrationBuilder.AddColumn<string>(
                name: "ProductIds",
                table: "PurchaseOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Quantities",
                table: "PurchaseOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PurchaseOrderDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseOrderDetails",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_Products_ProductId",
                table: "PurchaseOrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrders",
                principalColumn: "PurchaseOrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_Suppliers_SupplierId",
                table: "PurchaseOrderDetails",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_Products_ProductId",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_Suppliers_SupplierId",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseOrderDetails",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductIds",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "Quantities",
                table: "PurchaseOrders");

            migrationBuilder.RenameTable(
                name: "PurchaseOrderDetails",
                newName: "PurchaseOrdersDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderDetails_SupplierId",
                table: "PurchaseOrdersDetails",
                newName: "IX_PurchaseOrdersDetails_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrderId",
                table: "PurchaseOrdersDetails",
                newName: "IX_PurchaseOrdersDetails_PurchaseOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderDetails_ProductId",
                table: "PurchaseOrdersDetails",
                newName: "IX_PurchaseOrdersDetails_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PurchaseOrdersDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseOrdersDetails",
                table: "PurchaseOrdersDetails",
                column: "PurchaseOrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrdersDetails_Products_ProductId",
                table: "PurchaseOrdersDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrdersDetails_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrdersDetails",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrders",
                principalColumn: "PurchaseOrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrdersDetails_Suppliers_SupplierId",
                table: "PurchaseOrdersDetails",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId");
        }
    }
}
