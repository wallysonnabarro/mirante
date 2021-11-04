﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechBeauty.Dados;

namespace TechBeauty.Dados.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211103202046_dbinicio")]
    partial class dbinicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CargoContratoTrabalho", b =>
                {
                    b.Property<int>("CargosId")
                        .HasColumnType("int");

                    b.Property<int>("ContratosTrabalhosId")
                        .HasColumnType("int");

                    b.HasKey("CargosId", "ContratosTrabalhosId");

                    b.HasIndex("ContratosTrabalhosId");

                    b.ToTable("CargoContratoTrabalho");
                });

            modelBuilder.Entity("ColaboradorServico", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("ServicosId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "ServicosId");

                    b.HasIndex("ServicosId");

                    b.ToTable("ColaboradorServico");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("smalldateTime");

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("smalldateTime");

                    b.Property<DateTime>("DataHoraTermino")
                        .HasColumnType("smalldateTime");

                    b.Property<int>("OrdemServicoId")
                        .HasColumnType("int");

                    b.Property<string>("PessoaAtendida")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("OrdemServicoId");

                    b.HasIndex("ServicoId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Beneficio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Beneficio");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeneficioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraFechamento")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("LucroDiario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SaldoFinalCaixa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SaldoInicial")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BeneficioId");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TipoId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.ContratoTrabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CnpjCTPS")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataDesligamento")
                        .HasColumnType("smallDateTime");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("smallDateTime");

                    b.Property<int>("RegimeContratualId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("RegimeContratualId");

                    b.ToTable("ContratoTrabalho");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Escala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHoraEntrada")
                        .HasColumnType("smallDateTime");

                    b.Property<DateTime>("DataHoraSaida")
                        .HasColumnType("smallDateTime");

                    b.HasKey("Id");

                    b.ToTable("Escala");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.EspacoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeneficioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeneficioId");

                    b.ToTable("EspacoCliente");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.LogAgendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgendamentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("smallDateTime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendamentoId");

                    b.ToTable("Logs_Agendamentos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("DuracaoTotal")
                        .HasColumnType("int");

                    b.Property<int?>("EspacoClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoTotal")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EspacoClienteId");

                    b.ToTable("OrdemServico");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CaixaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraPagamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("int");

                    b.Property<int?>("OrdemServicoId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Troco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorRecebido")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.HasIndex("OrdemServicoId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.RegimeContratual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("RegimeContratual");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("DuracaoEmMin")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.TipoContato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("TipoContato");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Cliente", b =>
                {
                    b.HasBaseType("TechBeauty.Dominio.Modelo.Pessoa");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Colaborador", b =>
                {
                    b.HasBaseType("TechBeauty.Dominio.Modelo.Pessoa");

                    b.Property<string>("CarteiraTrabalho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("EscalaId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("NomeSocial")
                        .HasColumnType("varchar(100)");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("EscalaId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("CargoContratoTrabalho", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Cargo", null)
                        .WithMany()
                        .HasForeignKey("CargosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.ContratoTrabalho", null)
                        .WithMany()
                        .HasForeignKey("ContratosTrabalhosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColaboradorServico", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.Servico", null)
                        .WithMany()
                        .HasForeignKey("ServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Agendamento", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Colaborador", "Colaborador")
                        .WithMany("Agendamentos")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.OrdemServico", "OrdemServico")
                        .WithMany("Agendamento")
                        .HasForeignKey("OrdemServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.Servico", "Servico")
                        .WithMany("Agendamentos")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("OrdemServico");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Caixa", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Beneficio", "Beneficio")
                        .WithMany()
                        .HasForeignKey("BeneficioId");

                    b.Navigation("Beneficio");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Contato", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Pessoa", "Pessoa")
                        .WithMany("Contatos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.TipoContato", "Tipo")
                        .WithMany("Contatos")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.ContratoTrabalho", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Colaborador", "Colaborador")
                        .WithMany("Contratos")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.RegimeContratual", "RegimeContratual")
                        .WithMany("ContratosDeTrabalho")
                        .HasForeignKey("RegimeContratualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("RegimeContratual");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.EspacoCliente", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Beneficio", "Beneficio")
                        .WithMany()
                        .HasForeignKey("BeneficioId");

                    b.Navigation("Beneficio");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.LogAgendamento", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Agendamento", "Agendamento")
                        .WithMany("LogAgendamentos")
                        .HasForeignKey("AgendamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agendamento");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.OrdemServico", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Cliente", "Cliente")
                        .WithMany("OrdensServicos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.EspacoCliente", null)
                        .WithMany("OrdemServicos")
                        .HasForeignKey("EspacoClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Pagamento", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Caixa", null)
                        .WithMany("Pagamentos")
                        .HasForeignKey("CaixaId");

                    b.HasOne("TechBeauty.Dominio.Modelo.OrdemServico", "OrdemServico")
                        .WithMany()
                        .HasForeignKey("OrdemServicoId");

                    b.Navigation("OrdemServico");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Usuario", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Cliente", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("TechBeauty.Dominio.Modelo.Cliente", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Colaborador", b =>
                {
                    b.HasOne("TechBeauty.Dominio.Modelo.Endereco", "Endereco")
                        .WithMany("Colaboradores")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.Escala", "Escala")
                        .WithMany("Colaboradores")
                        .HasForeignKey("EscalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.Genero", "Genero")
                        .WithMany("Colaboradores")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBeauty.Dominio.Modelo.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("TechBeauty.Dominio.Modelo.Colaborador", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Escala");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Agendamento", b =>
                {
                    b.Navigation("LogAgendamentos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Caixa", b =>
                {
                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Endereco", b =>
                {
                    b.Navigation("Colaboradores");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Escala", b =>
                {
                    b.Navigation("Colaboradores");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.EspacoCliente", b =>
                {
                    b.Navigation("OrdemServicos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Genero", b =>
                {
                    b.Navigation("Colaboradores");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.OrdemServico", b =>
                {
                    b.Navigation("Agendamento");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Pessoa", b =>
                {
                    b.Navigation("Contatos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.RegimeContratual", b =>
                {
                    b.Navigation("ContratosDeTrabalho");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Servico", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.TipoContato", b =>
                {
                    b.Navigation("Contatos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Cliente", b =>
                {
                    b.Navigation("OrdensServicos");
                });

            modelBuilder.Entity("TechBeauty.Dominio.Modelo.Colaborador", b =>
                {
                    b.Navigation("Agendamentos");

                    b.Navigation("Contratos");
                });
#pragma warning restore 612, 618
        }
    }
}
