using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Data.migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    _id = table.Column<string>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    HasSunRoof = table.Column<bool>(nullable: false),
                    IsFourWheelDrive = table.Column<bool>(nullable: false),
                    HasLowMiles = table.Column<bool>(nullable: false),
                    HasPowerWindws = table.Column<bool>(nullable: false),
                    HasNavigation = table.Column<bool>(nullable: false),
                    HasHeatedSeat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x._id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
