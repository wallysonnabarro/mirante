using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dados.Repositorio
{
    public class BeneficioRepositorio : RepositorioBase<Beneficio>
    {
        public override int Incluir(Beneficio entity)
        {
            if (context.Beneficio.Any(b => b.Nome == entity.Nome))
            {
                return base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException($"Beneficio {entity.Nome} já existe!", nameof(entity.Nome));
            }
        }
    }
}
