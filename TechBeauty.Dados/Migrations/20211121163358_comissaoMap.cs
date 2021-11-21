using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class comissaoMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comissao_AgendamentoId",
                table: "Comissao");

            migrationBuilder.CreateIndex(
                name: "IX_Comissao_AgendamentoId",
                table: "Comissao",
                column: "AgendamentoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comissao_AgendamentoId",
                table: "Comissao");

            migrationBuilder.CreateIndex(
                name: "IX_Comissao_AgendamentoId",
                table: "Comissao",
                column: "AgendamentoId");
        }
    }
}
