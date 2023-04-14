using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class dobavljaci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Dobavljaci",
                columns: new[] { "DobavljacID", "Adresa", "BrojTelefona", "Naziv" },
                values: new object[] { 2, "Dr Ante Starcevica 52, Mostar", "062111111", "Najbolji Dobavljac2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dobavljaci",
                keyColumn: "DobavljacID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2d913c22-6639-42c9-a6d0-8cf9c9fce698");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5b7c32d5-b5ef-4c39-9f54-878376776962");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c05afd17-2233-4c37-bab1-8ceb10880def", "AQAAAAEAACcQAAAAEC6VDKDnbMTSIffP9kDpd6mEOvtnqlGt06H9+CazY4CioaS++litPzwrP6HSIcxAsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23ae1452-ab05-4aab-9646-f457830ff7af", "AQAAAAEAACcQAAAAEKCuUoitZ/wcZspaHzMDjAsBuHw3pJ8bdiSGHYXnbv73Lmu1elq7Xl1aog1e6232Aw==" });
        }
    }
}
