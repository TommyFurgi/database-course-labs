using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_EF.Migrations
{
    /// <inheritdoc />
    public partial class zad_d3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceItemID",
                table: "InvoiceItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems",
                column: "InvoiceItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "InvoiceItemID",
                table: "InvoiceItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems",
                columns: new[] { "InvoiceNumber", "ProductID" });
        }
    }
}
