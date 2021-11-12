using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class OrdemServicoRepositorio : RepositorioBase<OrdemServico>
    {
        public void AlterarStatus(int id)
        {

            if (!context.OrdemServico.Any(x => x.Id == id))
            {
                context.OrdemServico.FirstOrDefault(x => x.Id == id).AlterarStatus(id);
            }
            throw new ArgumentException($"Identificação {id}", nameof(id));


        }
    }
}
