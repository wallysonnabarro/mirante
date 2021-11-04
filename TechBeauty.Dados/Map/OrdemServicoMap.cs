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
    class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PrecoTotal)
           .HasColumnType("decimal(6,2)")
           .IsRequired();

            builder.Property(x => x.DuracaoTotal)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.Status)
               .HasColumnType("int")
               .IsRequired();

            builder.HasOne(os => os.Cliente) // os tem apenas 1 cliente (1,1)
                .WithMany(c => c.OrdensServicos) // 1 cliente pode estar em várias OS's (1,n)
                .IsRequired();

            builder.HasMany(os => os.Agendamento) // os tem vários agendamentos (1,n)
                .WithOne(a => a.OrdemServico) // agendamento tem apenas 1 OS (1,1) 
                .IsRequired();
        }
    }
}
