using Microsoft.EntityFrameworkCore.Migrations;

namespace parcial2naipe.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Naipe",
                columns: table => new
                {
                    IdCancion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCarta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnlaceCarta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naipe", x => x.IdCancion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Naipe");
        }
    }
}
