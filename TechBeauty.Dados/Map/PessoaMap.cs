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
    class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(p => p.CPF).HasColumnType("varchar(11)").IsRequired();

            builder.Property(p => p.DataNascimento).HasColumnType("date");

            builder.HasMany(p => p.Contatos) //uma pesssoa pode ter vários contatos (1,n) 
                .WithOne(c => c.Pessoa) // um contato pode ter apenas 1 pessoa (1,1)
                .IsRequired();
        }
    }
}
