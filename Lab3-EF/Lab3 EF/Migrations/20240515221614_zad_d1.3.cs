using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_EF.Migrations
{
    /// <inheritdoc />
    public partial class zad_d13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceNumber1",
                table: "InvoiceItems");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItems_InvoiceNumber1",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "InvoiceNumber1",
                table: "InvoiceItems",
                newName: "InvoiceItemID");

            migrationBuilder.AddColumn<string>(
                name: "BankAccountNumber",
                table: "Suppliers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Suppliers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Suppliers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceNumber",
                table: "InvoiceItems",
                column: "InvoiceNumber",
                principalTable: "Invoices",
                principalColumn: "InvoiceNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceNumber",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "InvoiceItemID",
                table: "InvoiceItems",
                newName: "InvoiceNumber1");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Suppliers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Suppliers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Suppliers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceNumber1",
                table: "InvoiceItems",
                column: "InvoiceNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceNumber1",
                table: "InvoiceItems",
                column: "InvoiceNumber1",
                principalTable: "Invoices",
                principalColumn: "InvoiceNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
