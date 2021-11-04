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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Nome).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.Password)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.HasOne(u => u.Gestao) 
                .WithMany(g => g.Usuarios) 
                .IsRequired();

            builder.HasOne(u => u.Cargo)
                   .WithMany(c => c.Usuarios)
                   .IsRequired();
        }
    }
}
