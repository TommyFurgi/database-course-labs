using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_EF.Migrations
{
    /// <inheritdoc />
    public partial class zad_d5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "InvoiceItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "InvoiceItems");
        }
    }
}
