using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace matchlove.Migrations
{
    public partial class M08CreateTablesDasPreferecias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Infos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HobbyId",
                table: "Infos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicaId",
                table: "Infos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Musicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    artista = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicas", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Infos_FilmeId",
                table: "Infos",
                column: "FilmeId",
                unique: true,
                filter: "[FilmeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_HobbyId",
                table: "Infos",
                column: "HobbyId",
                unique: true,
                filter: "[HobbyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_MusicaId",
                table: "Infos",
                column: "MusicaId",
                unique: true,
                filter: "[MusicaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_PessoaId",
                table: "Infos",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Filmes_FilmeId",
                table: "Infos",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Hobbies_HobbyId",
                table: "Infos",
                column: "HobbyId",
                principalTable: "Hobbies",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Musicas_MusicaId",
                table: "Infos",
                column: "MusicaId",
                principalTable: "Musicas",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Pessoas_PessoaId",
                table: "Infos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Filmes_FilmeId",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Hobbies_HobbyId",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Musicas_MusicaId",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Pessoas_PessoaId",
                table: "Infos");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Musicas");

            migrationBuilder.DropIndex(
                name: "IX_Infos_FilmeId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_HobbyId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_MusicaId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_PessoaId",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "HobbyId",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "MusicaId",
                table: "Infos");
        }
    }
}
