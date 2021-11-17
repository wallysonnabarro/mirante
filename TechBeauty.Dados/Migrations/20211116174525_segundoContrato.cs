using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class segundoContrato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CargoContratoTrabalho",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CargoContratoTrabalho_CargosId",
                table: "CargoContratoTrabalho",
                column: "CargosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_CargoContratoTrabalho_CargosId",
                table: "CargoContratoTrabalho");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CargoContratoTrabalho");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho",
                columns: new[] { "CargosId", "ContratosTrabalhosId" });
        }
    }
}
