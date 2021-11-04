using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamentos").HasKey(a => a.Id);

            builder.Property(a => a.DataHoraCriacao).HasColumnType("smalldateTime").IsRequired();
            builder.Property(a => a.DataHoraInicio).HasColumnType("smalldateTime").IsRequired();
            builder.Property(a => a.DataHoraTermino).HasColumnType("smalldateTime").IsRequired();
            builder.Property(a => a.Status).HasColumnType("int").IsRequired();
            builder.Property(a => a.PessoaAtendida).HasColumnType("varchar(30)");


            builder.HasOne(a => a.Servico) // 1 agendamento tem apenas 1 servico (1,1)
                .WithMany(s => s.Agendamentos) // 1 serviço tem vários agendamentos (1,n)
                .IsRequired();

            builder.HasOne(a => a.Colaborador) // 1 agendamento tem apenas 1 servico (1,1)
                .WithMany(c => c.Agendamentos) // 1 colaborador tem diversos agendamentos (1,n) 
                .IsRequired();

            builder.HasMany(a => a.LogAgendamentos) // 1 agendamento para vários logs (1,n)
                .WithOne(l => l.Agendamento) // 1 log para 1 agendamento (1,1)
                .IsRequired();

        }
    }
}
