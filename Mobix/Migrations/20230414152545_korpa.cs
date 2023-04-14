using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class korpa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                table: "Proizvodi");

            migrationBuilder.AlterColumn<int>(
                name: "DobavljacProizvodaID",
                table: "Proizvodi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Korpa_AspNetUsers_KorisnikId1",
                        column: x => x.KorisnikId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KorpaStavke",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorpaId = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorpaStavke", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KorpaStavke_Korpa_KorpaId",
                        column: x => x.KorpaId,
                        principalTable: "Korpa",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorpaStavke_Proizvodi_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "693d842c-b482-4174-8565-97baad201c36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3e3366e7-d6a7-4053-a0bb-4f26244e75c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a7f976d-b3cf-4eef-a7dd-beaf6a1ed172", "AQAAAAEAACcQAAAAEIg2WFDsyYXSSIXJzC7GZB0+Yd0SlE8yjyhU3J0Y7DygjtsaJUt6W2T8VhqMYJD8Eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0de6f4bf-f486-4968-924e-ce8d04be243f", "AQAAAAEAACcQAAAAEGPhjIjXtC8wbC6hO94UetN82Ll8LLsihsjeUb8WCsvTIrQoZPT/TIl13hCAfMIAUg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KorisnikId1",
                table: "Korpa",
                column: "KorisnikId1");

            migrationBuilder.CreateIndex(
                name: "IX_KorpaStavke_KorpaId",
                table: "KorpaStavke",
                column: "KorpaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorpaStavke_ProizvodID",
                table: "KorpaStavke",
                column: "ProizvodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                table: "Proizvodi",
                column: "DobavljacProizvodaID",
                principalTable: "Dobavljaci",
                principalColumn: "DobavljacID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                table: "Proizvodi");

            migrationBuilder.DropTable(
                name: "KorpaStavke");

            migrationBuilder.DropTable(
                name: "Korpa");

            migrationBuilder.AlterColumn<int>(
                name: "DobavljacProizvodaID",
                table: "Proizvodi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7eb7196a-fb54-45e5-8182-7746a59595fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6287cd00-f9e8-4341-93cf-9a8748cc3c23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fcaa763-8cca-4fee-9265-06f0442008f5", "AQAAAAEAACcQAAAAEELYo3Vw3OGufz6o1bA5tCTdoAPk6Vmk2xEw+GO11zjFN9xZqTk8u0kIsugE9IUyWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97bcbf0f-2bff-402c-a0af-a5ff2a5bb1c6", "AQAAAAEAACcQAAAAEAVHscBvYJ5q9OXQ+l27DoddGPd1NHu/1dJWActcCacJ9Iwv2pf12XZJJ/nXTXtaOw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                table: "Proizvodi",
                column: "DobavljacProizvodaID",
                principalTable: "Dobavljaci",
                principalColumn: "DobavljacID");
        }
    }
}
