using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Dtos;

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
