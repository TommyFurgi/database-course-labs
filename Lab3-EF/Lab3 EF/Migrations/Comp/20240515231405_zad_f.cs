using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_EF.Migrations.Comp
{
    /// <inheritdoc />
    public partial class zad_f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Companies");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Customers_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BankAccountNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Suppliers_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.AddColumn<string>(
                name: "BankAccountNumber",
                table: "Companies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Companies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Companies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Companies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Companies",
                type: "INTEGER",
                nullable: true);
        }
    }
}
