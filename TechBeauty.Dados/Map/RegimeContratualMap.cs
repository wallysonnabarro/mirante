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
    class RegimeContratualMap : IEntityTypeConfiguration<RegimeContratual>
    {
        
        public void Configure(EntityTypeBuilder<RegimeContratual> builder)
        {
            builder.ToTable("RegimeContratual"); //criando a tabela 
            builder.HasKey(x => x.Id); // chave primaria 

            builder.Property(x => x.Valor)
                .HasColumnType("varchar(20)") // referencia a propriedade e seu tamanho
                .IsRequired();

            builder.HasMany(rc => rc.ContratosDeTrabalho) // regime contratual pode ter vários ContratosTrabalhos (1,n)
                .WithOne(c => c.RegimeContratual) // ContratoTrabalho tem apenas 1 regime contratual (1,1)
                .IsRequired(); //é obrigatório o preenchimento, e automaticamente é excluido o conteúdo como um todo 
            //e unificado pelo ID
        }
    }
}
