using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebInventoryManagementSystem_IT703_2016012187.Migrations
{
    public partial class nullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomingOrder_Inventory_InventoryId",
                table: "IncomingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingOrder_Product_ProductId",
                table: "IncomingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingOrder_Supplier_SupplierId",
                table: "IncomingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Location_LocationId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_OutgoingOrder_Client_ClientId",
                table: "OutgoingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_OutgoingOrder_Inventory_InventoryId",
                table: "OutgoingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_OutgoingOrder_Product_ProductId",
                table: "OutgoingOrder");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OutgoingOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "OutgoingOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "OutgoingOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Inventory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Inventory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "IncomingOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "IncomingOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "IncomingOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingOrder_Inventory_InventoryId",
                table: "IncomingOrder",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingOrder_Product_ProductId",
                table: "IncomingOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingOrder_Supplier_SupplierId",
                table: "IncomingOrder",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Location_LocationId",
                table: "Inventory",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OutgoingOrder_Client_ClientId",
                table: "OutgoingOrder",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_OutgoingOrder_Inventory_InventoryId",
                table: "OutgoingOrder",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_OutgoingOrder_Product_ProductId",
                table: "OutgoingOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomingOrder_Inventory_InventoryId",
                table: "IncomingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingOrder_Product_ProductId",
                table: "IncomingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingOrder_Supplier_SupplierId",
                table: "IncomingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Location_LocationId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_OutgoingOrder_Client_ClientId",
                table: "OutgoingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_OutgoingOrder_Inventory_InventoryId",
                table: "OutgoingOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_OutgoingOrder_Product_ProductId",
                table: "OutgoingOrder");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OutgoingOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "OutgoingOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "OutgoingOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "IncomingOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "IncomingOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "IncomingOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingOrder_Inventory_InventoryId",
                table: "IncomingOrder",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingOrder_Product_ProductId",
                table: "IncomingOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingOrder_Supplier_SupplierId",
                table: "IncomingOrder",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Location_LocationId",
                table: "Inventory",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutgoingOrder_Client_ClientId",
                table: "OutgoingOrder",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutgoingOrder_Inventory_InventoryId",
                table: "OutgoingOrder",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutgoingOrder_Product_ProductId",
                table: "OutgoingOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
