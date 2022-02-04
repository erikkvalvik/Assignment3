using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class updatingDatabaseConnectionTableMovieCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterMovie",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMovie", x => new { x.CharactersId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacters_CharacterId",
                table: "MovieCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacters_MovieId",
                table: "MovieCharacters",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovie_MoviesId",
                table: "CharacterMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCharacters_Characters_CharacterId",
                table: "MovieCharacters",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCharacters_Movies_MovieId",
                table: "MovieCharacters",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCharacters_Characters_CharacterId",
                table: "MovieCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCharacters_Movies_MovieId",
                table: "MovieCharacters");

            migrationBuilder.DropTable(
                name: "CharacterMovie");

            migrationBuilder.DropIndex(
                name: "IX_MovieCharacters_CharacterId",
                table: "MovieCharacters");

            migrationBuilder.DropIndex(
                name: "IX_MovieCharacters_MovieId",
                table: "MovieCharacters");
        }
    }
}
