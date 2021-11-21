using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dados.Map
{
    class ComissaoMap : IEntityTypeConfiguration<Comissao>
    {
        public void Configure(EntityTypeBuilder<Comissao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Agendamento)
                .WithOne(a => a.Comissao)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
