using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SampleWebApiDotNetCore.Migrations
{
    /// <inheritdoc />
    public partial class bookdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 2, "AAA", "tesT", 1991 },
                    { 3, "BBB", "tesT2", 1993 },
                    { 4, "CCC", "tesT3", 1945 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
