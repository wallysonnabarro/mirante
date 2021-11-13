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
        public void GerarComissao(Agendamento agendamento)
        {
            var contratoTrabalho = agendamento.Colaborador.Contratos.FirstOrDefault(x => x.Id == agendamento.Colaborador.Id);

            if (contratoTrabalho.CnpjCTPS.ToUpper().Equals("CNPJ"))
            {
                Comissao.GerarComissao(agendamento, 0.60M);
            }
            else
            {
                Comissao.GerarComissao(agendamento, 0.45M);
            }
        }

        public List<Comissao> ListagemComissao(int colaboradorId)
        {
            List<Comissao> lista = new();
            if (context.Colaborador.FirstOrDefault(x => x.Id == colaboradorId) != null)
            {
                //Pegar a data atual e subtrair 30 dias dela                
                //Data inicio da Agendamento
                //Data termino da Agendamento
                //Data status da Agendamento = concluido
                //Data status da Agendamento = Parcialmente concluido = não existe na enum
                return context.Comissao
                    .Where(c => c.Agendamento.Colaborador.Id == colaboradorId
                    && c.Agendamento.Status == StatusAgendamento.Concluido
                    && c.Agendamento.DataHoraCriacao >= DateTime.Now.AddDays(-29).AddSeconds(-1)
                    && c.Agendamento.DataHoraCriacao <= DateTime.Now)
                    .OrderBy(x => x.Id)
                    .ToList();
            }
            throw new ArgumentException($"Codigo incorreto! {colaboradorId}", nameof(colaboradorId));
        }

        internal void RegistrarPorcentagem(Agendamento agendamento)
        {
            base.Incluir(Comissao.GerarComissao(agendamento, context.Servico.FirstOrDefault(s => s.Id == agendamento.Servico.Id).Preco));
        }
    }
}
