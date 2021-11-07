using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class AgendamentoRepositorio : RepositorioBase<Agendamento>
    {
        public List<Agendamento> AgendamentosPorOrdemServico(int idOrdem)
        {
            return context.Agendamento.Where(
                x => x.Id == idOrdem).ToList();
        }
    }
}
