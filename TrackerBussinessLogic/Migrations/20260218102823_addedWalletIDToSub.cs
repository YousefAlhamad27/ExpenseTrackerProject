using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerBussinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class addedWalletIDToSub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             

            migrationBuilder.AddColumn<int>(
                name: "WalletID",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 1);

             
                

             

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Wallets_WalletID",
                table: "Subscriptions",
                column: "WalletID",
                principalTable: "Wallets",
                principalColumn: "WalletID",
                onDelete: ReferentialAction.Restrict
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
