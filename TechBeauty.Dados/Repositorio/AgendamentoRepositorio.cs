using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dados.Repositorio
{
    public class AgendamentoRepositorio : RepositorioBase<Agendamento>
    {
        public List<Agendamento> AgendamentosPorOrdemServico(int idOrdem)
        {
            return context.Agendamento.Where(
                x => x.Id == idOrdem).OrderBy(x => x.Id).ToList();
        }

        public void ConcluirAgendamento(int id)
        {
            var agendamento = context.Agendamento.FirstOrDefault(a => a.Id == id);
            if (agendamento != null)
            {
                agendamento.AlterarStatusAgendamento(StatusAgendamento.Concluido);
                base.Alterar(agendamento);
                new ComissaoRepositorio().RegistrarPorcentagem(agendamento);
            }
            throw new ArgumentException($"Agendamento com o código= {id} não encontrado!", nameof(id));
        }
    }
}
