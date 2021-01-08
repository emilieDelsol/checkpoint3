using Microsoft.EntityFrameworkCore.Migrations;

namespace checkpointIdentity.Data.Migrations
{
    public partial class migrationProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Products");
        }
    }
}
