using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dados.Repositorio
{
    public class ComissaoRepositorio : RepositorioBase<Comissao>
    {

        public List<Comissao> ListagemComissao(int colaboradorId)
        {
            if (context.Colaborador.FirstOrDefault(x => x.Id == colaboradorId) != null)
            {
                int dia = DateTime.Now.Day;
                return context.Comissao
                    .Where(c => c.Agendamento.Colaborador.Id == colaboradorId
                    && c.Agendamento.Status == StatusAgendamento.Concluido
                    && c.Agendamento.DataHoraCriacao >= DateTime.Now.AddDays(-dia).AddSeconds(-1)
                    && c.Agendamento.DataHoraCriacao <= DateTime.Now)
                    .OrderBy(x => x.Id)
                    .ToList();
            }
            else
            {
                throw new ArgumentException($"Codigo incorreto! {colaboradorId}", nameof(colaboradorId));
            }
        }

        internal void RegistrarPorcentagem(Agendamento agendamento)
        {
            if (!context.Comissao.Any(c => c.AgendamentoId == agendamento.Id))
            {
                base.Incluir(Comissao.GerarComissao(
                    context.Servico.FirstOrDefault(s => s.Id == agendamento.ServicoId).Preco,
                    context.ContratoTrabalho.FirstOrDefault(ct => ct.Id == agendamento.ColaboradorId).PorcentagemComissao,
                    agendamento.Id));
            }
            else
            {
                throw new ArgumentException("Comissão já foi gerada para esse agendamento.");
            }
        }
    }
}
