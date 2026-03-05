using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerBussinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class IsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Wallets",
                type: "bit",
                nullable: false,
                defaultValue: true);

            

         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
             
        }
    }
}
