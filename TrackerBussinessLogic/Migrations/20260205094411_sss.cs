using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerBussinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class sss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                   name: "CurrencyID",
                   table: "Wallets",
                   type: "int",
                   defaultValue:1);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Currencies_CurrencyID",
                table: "Wallets",
                column: "CurrencyID",
                principalTable: "Currencies",
                principalColumn: "CurrencyID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
