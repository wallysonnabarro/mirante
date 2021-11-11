using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ServicoRepositorio : RepositorioBase<Servico>
    {
        public override int Incluir(Servico entity)
        {
            if (!context.Servico.All(s => s.Nome.Equals(entity.Nome)))
            {
                return base .Incluir(entity);
            }
            throw new ArgumentException();
        }
    }
}
