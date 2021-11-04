using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dados.Map
{
    public class GestaoMap : IEntityTypeConfiguration<Gestao>
    {
        public void Configure(EntityTypeBuilder<Gestao> builder)
        {
            builder.ToTable("Gestoes");
            builder.HasKey(x => x.Id);
            builder.Property(g => g.Salario).HasColumnType("decimal(6,2)").IsRequired();
            builder.Property(g => g.Receita).HasColumnType("decimal(6,2)").IsRequired();

            builder.HasMany(g => g.EspacoClientes)
                    .WithOne(ec => ec.Gestao)
                    .IsRequired();

            builder.HasMany(g => g.Usuarios)
                .WithOne(u => u.Gestao)
                .IsRequired();
        }
    }
}
