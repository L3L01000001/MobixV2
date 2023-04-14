using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class tabele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                table: "Proizvodi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proizvodi",
                table: "Proizvodi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dobavljaci",
                table: "Dobavljaci");

            migrationBuilder.RenameTable(
                name: "Proizvodi",
                newName: "Proizvod");

            migrationBuilder.RenameTable(
                name: "Dobavljaci",
                newName: "Dobavljac");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvodi_DobavljacProizvodaID",
                table: "Proizvod",
                newName: "IX_Proizvod_DobavljacProizvodaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proizvod",
                table: "Proizvod",
                column: "ProizvodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dobavljac",
                table: "Dobavljac",
                column: "DobavljacID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b51f94a8-ffd7-490b-933a-45d14b6a3f79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "90a42f9c-70b6-4a58-804d-e001d148843f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93bafdcf-f3f7-4ac2-a3b4-b92e4d1eedc3", "AQAAAAEAACcQAAAAEL/iR1mNOVyBnseSnZ2V7mRQsw4BF1orwKEDclyEOxwc3eyBrrHxvFwKJwdUOYn61Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb238dba-c38b-4f95-97a7-1873b951cd83", "AQAAAAEAACcQAAAAEN9DB8JhIpVGtP1HjrnPEqad1UZIyrtWSCDNTLoJG9JNuh1HRCE1jZqy82FEcYsA8w==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Dobavljac_DobavljacProizvodaID",
                table: "Proizvod",
                column: "DobavljacProizvodaID",
                principalTable: "Dobavljac",
                principalColumn: "DobavljacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Dobavljac_DobavljacProizvodaID",
                table: "Proizvod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proizvod",
                table: "Proizvod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dobavljac",
                table: "Dobavljac");

            migrationBuilder.RenameTable(
                name: "Proizvod",
                newName: "Proizvodi");

            migrationBuilder.RenameTable(
                name: "Dobavljac",
                newName: "Dobavljaci");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_DobavljacProizvodaID",
                table: "Proizvodi",
                newName: "IX_Proizvodi_DobavljacProizvodaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proizvodi",
                table: "Proizvodi",
                column: "ProizvodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dobavljaci",
                table: "Dobavljaci",
                column: "DobavljacID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "30173ed3-1215-4172-9c8b-cb8e0d087d67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5c8757c0-3043-4c88-8786-e233ffcb7d46");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b27fad86-a188-431b-8adf-68241fc8a018", "AQAAAAEAACcQAAAAECdnLZtH6ECdrG3Qk/W4sVZmmlVd4Qj19qwWUg47kGW1lzdTvcYtmyEfCHQqENAvew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ea17c74-2f58-4e2a-a92f-592a927d4f39", "AQAAAAEAACcQAAAAEPWbxVf75E32/gRaFlD8lVg0le1vljB6AY3GPFyllnxOMpLumLXzDVuprL14fNS/wA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvodi_Dobavljaci_DobavljacProizvodaID",
                table: "Proizvodi",
                column: "DobavljacProizvodaID",
                principalTable: "Dobavljaci",
                principalColumn: "DobavljacID");
        }
    }
}
