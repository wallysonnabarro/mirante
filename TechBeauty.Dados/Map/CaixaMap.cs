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
    public class CaixaMap : IEntityTypeConfiguration<Caixa>
    {
        public void Configure(EntityTypeBuilder<Caixa> b)
        {
            b.ToTable("Caixas").HasKey(c => c.Id);

            b.Property(c => c.SaldoInicial).HasColumnType("decimal(6,2)").IsRequired();

            b.Property(c => c.SaldoFinalCaixa).HasColumnType("decimal(6,2)").IsRequired();

            b.Property(c => c.DataHoraCriacao).HasColumnType("smallDateTime").IsRequired();

            b.Property(c => c.DataHoraFechamento).HasColumnType("smallDateTime").IsRequired();

            b.Property(c => c.LucroDiario).HasColumnType("smallDateTime").IsRequired();

            b.HasMany(c => c.Pagamentos)
                .WithOne(p => p.Caixa)
                .IsRequired();

            b.HasOne(c => c.Gestao)
                .WithMany(g => g.Caixas)
                .IsRequired();
        }
    }
}
