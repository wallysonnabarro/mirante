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
    class ContratoTrabalhoMap : IEntityTypeConfiguration<ContratoTrabalho>
    {
        public void Configure(EntityTypeBuilder<ContratoTrabalho> builder)
        {
            builder.ToTable("ContratoTrabalho"); //nome da tabela
            builder.HasKey(x => x.Id); //chave primaria 

            builder.Property(x => x.DataEntrada)
                .HasColumnType("smallDateTime") //propriedade da classe 
                .IsRequired();

            builder.Property(x => x.DataDesligamento)
                .HasColumnType("smallDateTime");

            builder.Property(x => x.CnpjCTPS)
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder.HasMany(ct => ct.Cargos) //relacionamento de contratoTrabalho para varios cargos (n,n)
                .WithMany(c => c.ContratosTrabalhos); // relacionamento de cargo pra varios contratos (n.n)
                 //obs: Como o relacionamento é (n,n) não é necessário realizar o .IsRequerid();
        }
    }
}
