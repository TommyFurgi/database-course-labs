using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_EF.Migrations
{
    /// <inheritdoc />
    public partial class zad_d12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Invoice_InvoiceNumber1",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Products_ProductID",
                table: "InvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItem",
                table: "InvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceItem",
                newName: "InvoiceItems");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_ProductID",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_InvoiceNumber1",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_InvoiceNumber1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems",
                columns: new[] { "InvoiceNumber", "ProductID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "InvoiceNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceNumber1",
                table: "InvoiceItems",
                column: "InvoiceNumber1",
                principalTable: "Invoices",
                principalColumn: "InvoiceNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Products_ProductID",
                table: "InvoiceItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceNumber1",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Products_ProductID",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceItems",
                newName: "InvoiceItem");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_ProductID",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_InvoiceNumber1",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_InvoiceNumber1");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Invoice",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "InvoiceNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItem",
                table: "InvoiceItem",
                columns: new[] { "InvoiceNumber", "ProductID" });

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Invoice_InvoiceNumber1",
                table: "InvoiceItem",
                column: "InvoiceNumber1",
                principalTable: "Invoice",
                principalColumn: "InvoiceNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Products_ProductID",
                table: "InvoiceItem",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
