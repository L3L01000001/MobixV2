using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobix.Migrations
{
    public partial class korpaStavkaMod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "KorpaStavke",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "555346cf-2ab7-4405-bad7-423adab7c7c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7a6ace2e-440d-44e5-ae36-1a5816ab74b8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14dc27ce-c45b-431b-b821-49c913c639a5", "AQAAAAEAACcQAAAAEA+t6A9Ynpjmrt77NsfufGRCEDVkveFAQtwQgX1BQWfUwkyRPziwqupC7S0jZj7tFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6de2246-1fe1-4881-94ec-8870ff44d227", "AQAAAAEAACcQAAAAECX98XHmcB9UPIg74UlXhw7E0DTs9IEN2EwqQs0nZRQ/vvfuTrKfRWtyhY4uIxoFvQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "KorpaStavke");

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
        }
    }
}
