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
    class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaborador");

            builder.Property(x => x.NomeSocial)
               .HasColumnType("varchar(100)");


            builder.HasOne(c => c.Genero) // 1 colaborador por ter apenas 1 genero (1,1)
                .WithMany(g => g.Colaboradores) //1 genero pode ter vários colaboradores (1,n)
                .IsRequired();

            builder.HasOne(c => c.Endereco) // 1 colaborador tem apenas 1 endereco(1,1)
                .WithMany(e => e.Colaboradores) // 1 endereco pode ter vários colaboradores (1,n) 
                .IsRequired();

            builder.HasMany(c => c.Contratos) // 1 colaborador pode ter vários contratos (1,n)
                .WithOne(ct => ct.Colaborador) // 1 contratoTrabalho pode ter apenas 1 colaborador(1,1)
                .IsRequired();


            builder.HasMany(c => c.Servicos) // 1 colaborador pode ter vários servicos (1,n)
                .WithMany(s => s.Colaboradores);// 1 servico pode ter vários colaboradores (1,n) 

        }
    }
}
