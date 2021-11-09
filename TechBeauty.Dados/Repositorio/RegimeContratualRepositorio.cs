using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class RegimeContratualRepositorio : RepositorioBase<RegimeContratual>
    {
        public override void Incluir(RegimeContratual entity)
        {
            if (!context.RegimeContratual.All(rc => rc.Valor.Equals(entity.Valor)))
            {
                base.Incluir(entity);
            }
        }
    }
}
