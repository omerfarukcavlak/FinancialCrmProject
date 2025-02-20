using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialCRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankBills");

            migrationBuilder.DropTable(
                name: "BankSpendings");

            migrationBuilder.AddColumn<bool>(
                name: "IsIncoming",
                table: "Banks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIncoming",
                table: "Banks");

            migrationBuilder.CreateTable(
                name: "BankBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBills_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankBills_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankSpendings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    SpendingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankSpendings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankSpendings_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankSpendings_Spendings_SpendingId",
                        column: x => x.SpendingId,
                        principalTable: "Spendings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankBills_BankId",
                table: "BankBills",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankBills_BillId",
                table: "BankBills",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BankSpendings_BankId",
                table: "BankSpendings",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankSpendings_SpendingId",
                table: "BankSpendings",
                column: "SpendingId");
        }
    }
}
