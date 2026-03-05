using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerBussinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class NotNullAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name:"CategoryID",
                table:"Subscriptions",
                type:"int",
                nullable:false
                );

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Categories_CategoryID",
                table: "Subscriptions",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict


                );
            migrationBuilder.DropColumn(
             name: "Amount",
             table: "Subscriptions"
             );


            migrationBuilder.AddColumn<decimal>(
                table: "Subscriptions",
                name: "Amount",
                type: "smallMoney",
                nullable: false
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
        }
    }
}
