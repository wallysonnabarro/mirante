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
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> b)
        {
            b.ToTable("Pagamentos").HasKey(p => p.Id);

            b.Property(p => p.DataHoraPagamento).HasColumnType("smallDateTime").IsRequired();

            b.Property(p => p.ValorRecebido).HasColumnType("decimal(6,2)").IsRequired();

            b.Property(p => p.Troco).HasColumnType("decimal(6,2)").IsRequired();

            b.HasOne(p => p.OrdemServico)
                .WithMany(os => os.Pagamentos)
                .IsRequired();

            b.HasOne(p => p.Caixa)
                .WithMany(c => c.Pagamentos)
                .IsRequired();
        }
    }
}
