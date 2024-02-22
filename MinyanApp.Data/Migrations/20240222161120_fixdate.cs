using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinyanApp.Data.Migrations
{
    public partial class fixdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataTime",
                table: "Minyans",
                newName: "DateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Minyans",
                newName: "DataTime");
        }
    }
}
