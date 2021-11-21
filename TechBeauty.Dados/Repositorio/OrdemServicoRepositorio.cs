using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class OrdemServicoRepositorio : RepositorioBase<OrdemServico>
    {
        public void AlterarStatus(int id)
        {
            if (context.OrdemServico.Any(x => x.Id == id))
            {
                context.OrdemServico.FirstOrDefault(x => x.Id == id).AlterarStatus(id);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"Identificação {id} de status não encontrado!", nameof(id));
            }
        }

        public int AbrirOrdemServico(OrdemServico ordem)
        {
            if (context.Cliente.Any(c => c.Id == ordem.ClienteId))
            {
                return base.Incluir(ordem);
            }
            else
            {
                throw new ArgumentException("Cliente não encontrado!", nameof(ordem.ClienteId));
            }
        }

        internal void AlterarTotalOrdemServico(Agendamento agendamento)
        {
            var ordem = base.Selecionar(agendamento.OrdemServicoId);
            ordem.AlterarPrecoTotalDuracao(context.Servico.FirstOrDefault(x => x.Id == agendamento.ServicoId));
            base.Alterar(ordem);
        }

        public override List<OrdemServico> Paginar(int skip, int take)
        {
            take = take > 0 ? take : 25;
            skip = skip >= 1 ? skip *= take : skip;

            return context.Set<OrdemServico>().Where(o => o.DataCriacao >= DateTime.Now.AddHours(-8)).OrderBy(c => c.Id).Skip(skip).Take(take).ToList();
        }
    }
}
