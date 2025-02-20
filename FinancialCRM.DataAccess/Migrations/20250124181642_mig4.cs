using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialCRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIncoming",
                table: "Banks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsIncoming",
                table: "Banks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
