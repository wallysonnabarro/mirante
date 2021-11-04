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
    class EscalaMap : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> builder)
        {
            builder.ToTable("Escala")
                .HasKey(x => x.Id);

            builder.Property(e => e.DataHoraEntrada).HasColumnType("smallDateTime").IsRequired();

            builder.Property(e => e.DataHoraSaida).HasColumnType("smallDateTime").IsRequired();



            builder.HasMany(e => e.Colaboradores) // 1 escala para varios colaboradores (1,n)
                .WithOne(c => c.Escala) // 1 colaborador pode ter apenas 1 escala (1,1)
                .IsRequired();
        }
    }
}
