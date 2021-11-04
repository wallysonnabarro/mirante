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
    class LogAgendamentoMap : IEntityTypeConfiguration<LogAgendamento>
    {
        public void Configure(EntityTypeBuilder<LogAgendamento> builder)
        {
            builder.ToTable("Logs_Agendamentos").HasKey(x => x.Id);

            builder.Property(l => l.DataCriacao).HasColumnType("smallDateTime").IsRequired();
            builder.Property(l => l.Status).HasColumnType("int").IsRequired();
          



        }
    }
}
