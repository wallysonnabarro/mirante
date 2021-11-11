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
        public override int Incluir(Colaborador entity)
        {
            if (!context.Colaborador.Any(c => c.CPF.Equals(entity.CPF)))
            {
                return base.Incluir(entity);
            }
            throw new ArgumentException();
        }
    }
}
