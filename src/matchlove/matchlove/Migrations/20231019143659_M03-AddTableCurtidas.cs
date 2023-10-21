using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace matchlove.Migrations
{
    public partial class M03AddTableCurtidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DenunciaId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Curtidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRemetente = table.Column<int>(type: "int", nullable: false),
                    IdDestinatario = table.Column<int>(type: "int", nullable: false),
                    DeuMatch = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curtidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denunciante = table.Column<int>(type: "int", nullable: false),
                    Denunciado = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    IdConteudo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pessoa1 = table.Column<int>(type: "int", nullable: false),
                    Pessoa2 = table.Column<int>(type: "int", nullable: false),
                    dataMatch = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DenunciaId",
                table: "Pessoas",
                column: "DenunciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Denuncia_DenunciaId",
                table: "Pessoas",
                column: "DenunciaId",
                principalTable: "Denuncia",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Denuncia_DenunciaId",
                table: "Pessoas");

            migrationBuilder.DropTable(
                name: "Curtidas");

            migrationBuilder.DropTable(
                name: "Denuncia");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_DenunciaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DenunciaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Pessoas");
        }
    }
}
