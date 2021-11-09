using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio : RepositorioBase<Cargo>
    {
        public override void Incluir(Cargo entity)
        {
            if (!context.Cargo.All(x => x.Nome.Equals(entity.Nome)))
            {
                base.Incluir(entity);
            }
            throw new ArgumentException();
        }

        public override void Alterar(Cargo entity)
        {
            if (context.Cargo.FirstOrDefault(c => c.Id == entity.Id) != null)
            {
                base.Alterar(entity);
            }
            throw new ArgumentException();
        }
    }
}
