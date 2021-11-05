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
    class ComissaoRepositorio : RepositorioBase<Comissao>
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
                DateTime dataInicio = DateTime.Now;//Pegar a data atual e subtrair 30 dias dela                
                //Data inicio da Agendamento
                //Data termino da Agendamento
                //Data status da Agendamento = concluido
                //Data status da Agendamento = Parcialmente concluido = não existe na enum
                return context.Comissao.Where(col => col.Id == colaboradorId)
                    .Where(status => status.Agendamento.Status == StatusAgendamento.Concluido)//status
                    .Where(dI => dI.Agendamento.DataHoraCriacao >= dataInicio)
                    .Where(dF => dF.Agendamento.DataHoraCriacao <= DateTime.Now)//Data fim dia atual
                    .ToList();
            }
            return lista;
        }

    }
}
