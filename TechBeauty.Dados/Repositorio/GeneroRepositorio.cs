using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;
using System;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio : RepositorioBase<Genero>
    {
        public override void Incluir(Genero entity)
        {
            if (!context.Genero.All(g => g.Valor.Equals(entity.Valor)))
            {
                base.Incluir(entity);
            }
            throw new ArgumentException("");
        }

        public override void Alterar(Genero entity)
        {
            if (context.Cargo.FirstOrDefault(g => g.Id == entity.Id) != null)
            {
                base.Alterar(entity);
            }
            throw new ArgumentException("");
        }
    }
}
