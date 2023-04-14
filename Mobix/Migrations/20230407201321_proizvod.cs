using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class proizvod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Proizvodi",
                columns: new[] { "ProizvodID", "Cijena", "DobavljacProizvodaID", "Kolicina", "Naziv", "Opis", "SlikaProizvoda", "Stanje" },
                values: new object[] { 1, 700, 2, 1, "iPhone 11", "Apple iPhone 11 GREEN \r\n-Memorija 128 GB\r\n-Mobitel je kao nov (stanje 10/10)\r\n-Svi dijelovi originalni, ništa mijenjano \r\n-Face id i True tone rade \r\n-Apsolutno sve ispravno i otključano\r\n-Fabrička kutija, originalne Apple slušalice, kabal za punjenje, zaštitno staklo, papiri", "https://pcmarket.ba/wp-content/uploads/2021/09/Apple-iPhone-11-64GB-Green..jpg", "Polovno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proizvodi",
                keyColumn: "ProizvodID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "38dbcedd-952f-4d37-9099-b254a8537c6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "98078c47-3aec-4c03-af7c-4b9e17affd33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "396ace45-bc89-43cc-8c3c-6ccf2dc8d574", "AQAAAAEAACcQAAAAEGV03mT7gnwlV7r7WdAybUBWadpBzkCi3E+mbNa5hs/EXwkaNCwDgnQpaJAA7DWNYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0dd8650-5a4d-4929-b933-49bfbf6f2186", "AQAAAAEAACcQAAAAEGuMUzyUwQ7+nIGt1Q5zfaH5JHXWweRqbAqD8ViIu2Oq+yUYICm+rBrhyb+lktzslw==" });
        }
    }
}
