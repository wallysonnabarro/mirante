using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class AgendamentoRepositorio
    {
        private readonly Context context;

        public AgendamentoRepositorio()
        {
            context = new();
        }

        public void Incluir(Agendamento agendamento)
        {
            context.Agendamento.Add(agendamento);
            context.SaveChanges();
        }

        public List<Agendamento> AgendamentosPorOrdemServico(int idOrdem)
        {
            return context.Agendamento.Where(
                x => x.Id == idOrdem).ToList();
        }

        public List<Agendamento> Tabela()
        {
            return context.Agendamento.ToList();
        }
    }
}
