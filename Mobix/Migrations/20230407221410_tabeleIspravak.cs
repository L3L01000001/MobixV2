using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class tabeleIspravak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
