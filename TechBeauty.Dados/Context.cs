using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TechBeauty.Dados.Map;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dados
{
    public class Context : DbContext
    {
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<RegimeContratual> RegimeContratual { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Beneficio> Beneficio { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<ContratoTrabalho> ContratoTrabalho { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Escala> Escala { get; set; }
        public DbSet<EspacoCliente> EspacoCliente { get; set; }
        public DbSet<LogAgendamento> LogAgendamento { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Gestao> Gestao { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Comissao> Comissao { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MIR-0536\SQLEXPRESS; Database=OTecDB; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new CargoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new ContratoTrabalhoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EscalaMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new LogAgendamentoMap());
            modelBuilder.ApplyConfiguration(new OrdemServicoMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new RegimeContratualMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
            modelBuilder.ApplyConfiguration(new TipoContatoMap());
            

            base.OnModelCreating(modelBuilder);

        }


    }
}
