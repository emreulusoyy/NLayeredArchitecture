using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_haberdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltBaslik",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "AnaBaslik",
                table: "Blogs",
                newName: "DevaminiOku");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DevaminiOku",
                table: "Blogs",
                newName: "AnaBaslik");

            migrationBuilder.AddColumn<string>(
                name: "AltBaslik",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
