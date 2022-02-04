using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class SeedingDatabaseWithConnectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CharacterMovies",
                columns: new[] { "CharacterId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 8, 7 },
                    { 7, 6 },
                    { 7, 5 },
                    { 7, 4 },
                    { 6, 6 },
                    { 6, 5 },
                    { 9, 7 },
                    { 6, 4 },
                    { 5, 5 },
                    { 5, 4 },
                    { 4, 1 },
                    { 3, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 5, 6 },
                    { 10, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "CharacterMovies",
                keyColumns: new[] { "CharacterId", "MovieId" },
                keyValues: new object[] { 10, 7 });
        }
    }
}
