using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class dobavljac1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Dobavljaci",
                keyColumn: "DobavljacID",
                keyValue: 1,
                columns: new[] { "Adresa", "Naziv" },
                values: new object[] { "Dr Ante Starcevica 51, Mostar", "Najbolji Dobavljac1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8b6df160-c6ac-430a-84ce-c9dd5f156e64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "67627a5a-708e-4023-94e0-2e226d11dbe4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "744c947a-1391-4f58-a25d-00dc817582e3", "AQAAAAEAACcQAAAAEI1+sACNICLWsRVq43uX5mnn1rTUzM7eInGTd1NGlBkRfzKHwSHO9xpKtLo2g8T4PQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f14aaad5-9ec3-4cff-a666-7ec1c083d81f", "AQAAAAEAACcQAAAAEFd9XDQDYSUe5mdeIjwkufxrBPcjaW5/oXKKbeYK9Kkx74I5UPQOQWrRq3ZvzRdpjw==" });

            migrationBuilder.UpdateData(
                table: "Dobavljaci",
                keyColumn: "DobavljacID",
                keyValue: 1,
                columns: new[] { "Adresa", "Naziv" },
                values: new object[] { "Dr Ante Starcevica 50, Mostar", "Najbolji Dobavljac" });
        }
    }
}
