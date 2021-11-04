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
    public class BeneficioMap : IEntityTypeConfiguration<Beneficio>
    {
        public void Configure(EntityTypeBuilder<Beneficio> builder)
        {
            builder.ToTable("Beneficios").HasKey(b => b.Id);

            builder.Property(b => b.Nome).HasColumnType("varchar(50)").IsRequired();
            
            builder.Property(b => b.Descricao).HasColumnType("varchar(150)").IsRequired();

        }
    }
}
