using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio : RepositorioBase<Cargo>
    {
        public override void Incluir(Cargo entity)
        {
            if(!context.Cargo.All(x=> x.Nome == entity.Nome))
            base.Incluir(entity);
        }
    }
}
