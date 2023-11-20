using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace matchlove.Migrations
{
    public partial class M09ResetTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DenunciaId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denunciado = table.Column<int>(type: "int", nullable: false),
                    Denunciante = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdConteudo = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.Id);
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
    }
}
