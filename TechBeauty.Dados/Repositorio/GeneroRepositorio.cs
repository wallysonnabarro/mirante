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
        public override int Incluir(Genero entity)
        {
            if (!context.Genero.Any(g => g.Valor == entity.Valor))
            {
                return base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException($"O genero {entity.Valor} já existe!", nameof(entity.Valor));
            }
        }

        public override void Alterar(Genero entity)
        {
            if (context.Genero.Any(g => g.Id == entity.Id))
            {
                base.Alterar(entity);
            }
            else
            {
                throw new ArgumentException($"Código {entity.Id} não encontrado!", nameof(entity.Id));
            }
        }
    }
}
