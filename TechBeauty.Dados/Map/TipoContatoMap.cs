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
    class TipoContatoMap : IEntityTypeConfiguration<TipoContato>
    {
        public void Configure(EntityTypeBuilder<TipoContato> builder)
        {
            builder.ToTable("TipoContato");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.HasMany(tc => tc.Contatos) // Um contato pode ter vários tipos de contato (1,n)
                .WithOne(c => c.Tipo) // um tipoContato pode ter apenas 1 contato (1,1)
                .IsRequired();
        }
    }
}
