using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace matchlove.Migrations
{
    public partial class M08CreateTablesDasPreferecias3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Infos_PessoaId_Custom",
                table: "Infos",
                newName: "IX_Infos_PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Infos_PessoaId",
                table: "Infos",
                newName: "IX_Infos_PessoaId_Custom");
        }
    }
}
