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
    class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Cidade)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(x => x.UF)
               .HasColumnType("varchar(2)")
               .IsRequired();

            builder.Property(x => x.Numero)
               .HasColumnType("varchar(15)")
               .IsRequired();

            builder.Property(x => x.Complemento)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Cep)
               .HasColumnType("varchar(8)")
               .IsRequired();

            builder.Property(x => x.Bairro)
               .HasColumnType("varchar(50)")
               .IsRequired();

        }
    }
}
