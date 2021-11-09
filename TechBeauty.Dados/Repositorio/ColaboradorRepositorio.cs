using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ColaboradorRepositorio : RepositorioBase<Colaborador>
    {
        public override void Incluir(Colaborador entity)
        {
            if (!context.Colaborador.All(c => c.CPF.Equals(entity.CPF)))
            {
                base.Incluir(entity);
            }
        }
    }
}
