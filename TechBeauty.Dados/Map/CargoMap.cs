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
    class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(150)")
               .IsRequired();
            builder.HasMany(c => c.Servicos)
                .WithOne(s => s.Cargo)
                .IsRequired();
            builder.HasMany(c => c.CargoContratosTrabalho) //relacionamento de contratoTrabalho para varios cargos (n,n)
               .WithOne(cct => cct.Cargo)
               .HasForeignKey(x => x.CargosId); // relacionamento de cargo pra varios contratos (n.n)
        }
    }
}
