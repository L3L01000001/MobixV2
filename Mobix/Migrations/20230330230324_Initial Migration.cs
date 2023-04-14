using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    DobavljacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.DobavljacID);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cijena = table.Column<int>(type: "int", nullable: false),
                    SlikaProizvoda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    DobavljacProizvodaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                        column: x => x.DobavljacProizvodaID,
                        principalTable: "Dobavljaci",
                        principalColumn: "DobavljacID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_DobavljacProizvodaID",
                table: "Proizvodi",
                column: "DobavljacProizvodaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Dobavljaci");
        }
    }
}
