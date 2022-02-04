using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "CharacterName", "Gender", "Picture" },
                values: new object[,]
                {
                    { 1, "Iron Man", "Tony Stark", "Male", "" },
                    { 2, "", "Thor", "Male", "" },
                    { 3, "Spider Man", "Peter Parker", "Male", "" },
                    { 4, "", "Black Widow", "Female", "" },
                    { 5, "Strider", "Aragorn", "Male", "" },
                    { 6, "", "Legolas", "Male", "" },
                    { 7, "", "Gimli", "Male", "" },
                    { 8, "The boy who lived", "Harry Potter", "Male", "" },
                    { 9, "", "Hermoine Granger", "Female", "" },
                    { 10, "", "Ron Weasly", "Male", "" }
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Superheroes that always somehow manages to save the world", "Marvel" },
                    { 2, "The best trilogy ever made.", "Lord of the Rings" },
                    { 3, "Wizard boy goes to school, but something goes wrong every year", "Harry Potter" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "FranchiseId", "Genre", "Picture", "ReleaseYear", "Title", "Trailer" },
                values: new object[,]
                {
                    { 1, "Joss Whedon", 1, "Action", "https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY1200_CR90,0,630,1200_AL_.jpg", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Avengers", "https://www.youtube.com/watch?v=eOrNdBpGMv8" },
                    { 2, "Taika Waititi", 1, "Action", "https://www.bing.com/th?id=A70092af279de08fc0762746dbdc6be61&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor: Ragnarok", "https://www.youtube.com/watch?v=ue80QwXMRHg" },
                    { 3, "Jon Watts", 1, "Action", "https://www.bing.com/th?id=Acd021478a99c6e1a187ebda0f186c36e&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spiderman: No way home", "https://www.youtube.com/watch?v=JfVOs4VSpmA" },
                    { 4, "Peter Jackson", 2, "Fantasy", "https://www.bing.com/th?id=Acd16d948d57a0e5c13b41182f01a9603&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings: The Fellowship of the Ring", "https://www.youtube.com/watch?v=cKEGZ-CvWHk" },
                    { 5, "Peter Jackson", 2, "Fantasy", "https://www.bing.com/th?id=Ac317d10bbc9daae44750cb84536c5802&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings: The Two Towers", "https://www.youtube.com/watch?v=LbfMDwc4azU" },
                    { 6, "Peter Jackson", 2, "Fantasy", "https://www.bing.com/th?id=A3bad55d4843d18e2809ce35612614455&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings: The Return of the King", "https://www.youtube.com/watch?v=KOQSQaGgJxs" },
                    { 7, "Chris Colombus", 3, "Fantasy", "https://www.bing.com/th?id=Ab77398b331e251965a55ab9e9a2dfbd7&w=113&h=170&c=7&o=6&dpr=1.5&pid=SANGAM", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Philosopher's Stone", "https://www.youtube.com/watch?v=6kkUw717s2w" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
