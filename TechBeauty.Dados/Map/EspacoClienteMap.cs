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
    public class EspacoClienteMap : IEntityTypeConfiguration<EspacoCliente>
    {
        public void Configure(EntityTypeBuilder<EspacoCliente> b)
        {
            b.ToTable("Espaco_clientes").HasKey(ec => ec.Id);

            b.HasOne(ec => ec.Gestao)
                .WithMany(g => g.EspacoClientes)
                .IsRequired();

            b.HasOne(ec => ec.Beneficio)
                .WithMany(ec => ec.EspacosClientes)
                .IsRequired();

            b.HasOne(ec => ec.Cliente)
                .WithMany(c => c.EspacoCliente)
                .IsRequired();
        }
    }
}
