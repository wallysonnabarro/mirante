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
        public int Agendar(Agendamento agendamento)
        {
            if (context.Servico.Any(x => x.Id == agendamento.ServicoId))
            {
                if (context.Escala.Any(x =>
                    x.ColaboradorId == agendamento.ColaboradorId
                    && x.DataHoraEntrada <= agendamento.DataHoraInicio
                    && x.DataHoraSaida >= agendamento.DataHoraTermino))
                {
                    new OrdemServicoRepositorio().AlterarTotalOrdemServico(agendamento);
                    return base.Incluir(agendamento);
                }
                else
                {
                    throw new ArgumentException("Agendamento incorreto, verificar novamente a escala do colaborador!");
                }
            }
            else
            {
                throw new ArgumentException("Serviço não encontrado!");
            }
        }

        public List<Agendamento> AgendamentosPorOrdemServico(int idOrdem)
        {
            return context.Agendamento.Where(
                x => x.Id == idOrdem).OrderBy(x => x.Id).ToList();
        }

        public void ConcluirAgendamento(int id)
        {
            var agendamento = context.Agendamento.FirstOrDefault(a => a.Id == id);
            if (agendamento != null && agendamento.Status != StatusAgendamento.Concluido)
            {
                agendamento.AlterarStatusAgendamento(StatusAgendamento.Concluido);
                base.Alterar(agendamento);
                new ComissaoRepositorio().RegistrarPorcentagem(agendamento);
            }
            else
            {
                throw new ArgumentException($"Agendamento com o código= {id} não encontrado ou já concluído!", nameof(id));
            }
        }

        public void Iniciar(int id)
        {
            var agendamento = context.Agendamento.FirstOrDefault(a => a.Id == id);
            if (agendamento != null && agendamento.Status != StatusAgendamento.Concluido)
            {
                agendamento.AlterarStatusAgendamento(StatusAgendamento.EmAndamento);
                base.Alterar(agendamento);
            }
            else
            {
                throw new ArgumentException("Agendamento não encontrado!", nameof(id));
            }
        }
    }
}
