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
     class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasMany(c => c.OrdensServicos)// 1 cliente pode ter vária OS (1,n)
                    .WithOne(os => os.Cliente)  //1 os pode ter apenas 1 cliente (1,1)
                    .IsRequired();
        }
    }
}
