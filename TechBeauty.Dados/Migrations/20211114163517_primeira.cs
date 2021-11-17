using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(15)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegimeContratual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegimeContratual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DuracaoEmMin = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servico_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(30)", nullable: false),
                    Password = table.Column<string>(type: "varchar(15)", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(256)", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_TipoContato_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TipoContato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecoTotal = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DuracaoTotal = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContratoTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEntrada = table.Column<DateTime>(type: "smallDateTime", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "smallDateTime", nullable: true),
                    CnpjCTPS = table.Column<string>(type: "varchar(14)", nullable: false),
                    PorcentagemComissao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegimeContratualId = table.Column<int>(type: "int", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_RegimeContratual_RegimeContratualId",
                        column: x => x.RegimeContratualId,
                        principalTable: "RegimeContratual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraEntrada = table.Column<DateTime>(type: "smallDateTime", nullable: false),
                    DataHoraSaida = table.Column<DateTime>(type: "smallDateTime", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escala_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gestoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: true),
                    Receita = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gestoes_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gestoes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicoId = table.Column<int>(type: "int", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: false),
                    PessoaAtendida = table.Column<string>(type: "varchar(30)", nullable: true),
                    DataHoraCriacao = table.Column<DateTime>(type: "smalldateTime", nullable: false),
                    OrdemServicoId = table.Column<int>(type: "int", nullable: false),
                    DataHoraInicio = table.Column<DateTime>(type: "smalldateTime", nullable: false),
                    DataHoraTermino = table.Column<DateTime>(type: "smalldateTime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_OrdemServico_OrdemServicoId",
                        column: x => x.OrdemServicoId,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CargoContratoTrabalho",
                columns: table => new
                {
                    CargosId = table.Column<int>(type: "int", nullable: false),
                    ContratosTrabalhosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoContratoTrabalho", x => new { x.CargosId, x.ContratosTrabalhosId });
                    table.ForeignKey(
                        name: "FK_CargoContratoTrabalho_Cargo_CargosId",
                        column: x => x.CargosId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoContratoTrabalho_ContratoTrabalho_ContratosTrabalhosId",
                        column: x => x.ContratosTrabalhosId,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaldoInicial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoFinalCaixa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataHoraCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraFechamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LucroDiario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RetiradasDiarias = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    GestaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caixa_Gestoes_GestaoId",
                        column: x => x.GestaoId,
                        principalTable: "Gestoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Caixa_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Espaco_clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeneficioId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    GestaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Espaco_clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Espaco_clientes_Beneficio_BeneficioId",
                        column: x => x.BeneficioId,
                        principalTable: "Beneficio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Espaco_clientes_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Espaco_clientes_Gestoes_GestaoId",
                        column: x => x.GestaoId,
                        principalTable: "Gestoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AgendamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comissao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comissao_Agendamentos_AgendamentoId",
                        column: x => x.AgendamentoId,
                        principalTable: "Agendamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs_Agendamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "smallDateTime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AgendamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs_Agendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Agendamentos_Agendamentos_AgendamentoId",
                        column: x => x.AgendamentoId,
                        principalTable: "Agendamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdemServicoId = table.Column<int>(type: "int", nullable: false),
                    CaixaId = table.Column<int>(type: "int", nullable: false),
                    DataHoraPagamento = table.Column<DateTime>(type: "smallDateTime", nullable: false),
                    ValorRecebido = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Troco = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Forma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Caixa_CaixaId",
                        column: x => x.CaixaId,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamentos_OrdemServico_OrdemServicoId",
                        column: x => x.OrdemServicoId,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ColaboradorId",
                table: "Agendamentos",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_OrdemServicoId",
                table: "Agendamentos",
                column: "OrdemServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ServicoId",
                table: "Agendamentos",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_GestaoId",
                table: "Caixa",
                column: "GestaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_UsuarioId",
                table: "Caixa",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoContratoTrabalho_ContratosTrabalhosId",
                table: "CargoContratoTrabalho",
                column: "ContratosTrabalhosId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_EnderecoId",
                table: "Colaborador",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_GeneroId",
                table: "Colaborador",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Comissao_AgendamentoId",
                table: "Comissao",
                column: "AgendamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_PessoaId",
                table: "Contato",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TipoId",
                table: "Contato",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_ColaboradorId",
                table: "ContratoTrabalho",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_RegimeContratualId",
                table: "ContratoTrabalho",
                column: "RegimeContratualId");

            migrationBuilder.CreateIndex(
                name: "IX_Escala_ColaboradorId",
                table: "Escala",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Espaco_clientes_BeneficioId",
                table: "Espaco_clientes",
                column: "BeneficioId");

            migrationBuilder.CreateIndex(
                name: "IX_Espaco_clientes_ClienteId",
                table: "Espaco_clientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Espaco_clientes_GestaoId",
                table: "Espaco_clientes",
                column: "GestaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gestoes_ColaboradorId",
                table: "Gestoes",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Gestoes_UsuarioId",
                table: "Gestoes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_Agendamentos_AgendamentoId",
                table: "Logs_Agendamentos",
                column: "AgendamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_ClienteId",
                table: "OrdemServico",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_CaixaId",
                table: "Pagamentos",
                column: "CaixaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_OrdemServicoId",
                table: "Pagamentos",
                column: "OrdemServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_CargoId",
                table: "Servico",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CargoId",
                table: "Usuarios",
                column: "CargoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoContratoTrabalho");

            migrationBuilder.DropTable(
                name: "Comissao");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Escala");

            migrationBuilder.DropTable(
                name: "Espaco_clientes");

            migrationBuilder.DropTable(
                name: "Logs_Agendamentos");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "ContratoTrabalho");

            migrationBuilder.DropTable(
                name: "TipoContato");

            migrationBuilder.DropTable(
                name: "Beneficio");

            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "RegimeContratual");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Gestoes");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
