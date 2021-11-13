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
        public override int Incluir(RegimeContratual entity)
        {
            if (!context.RegimeContratual.Any(rc => rc.Valor == entity.Valor))
            {
                return base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override void Alterar(RegimeContratual entity)
        {
            if (!context.RegimeContratual.Any(r => r.Valor == entity.Valor))
            {
                base.Alterar(entity);
            }
            else
            {
                throw new ArgumentException($"O regime {entity.Valor}, já existe no banco de dados", nameof(entity.Valor));
            }
        }

    }
}
