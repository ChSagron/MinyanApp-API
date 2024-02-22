using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinyanApp.Data.Migrations
{
    public partial class updatesynagoguefavorite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Synagogues",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Synagogues");
        }
    }
}
