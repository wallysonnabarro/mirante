using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dados.Repositorio
{
    public class PagamentoRepositorio : RepositorioBase<Pagamento>
    {
        public void AlterarDataHora(int id, DateTime dataHoraPagamento)
        {
            context.Pagamento.FirstOrDefault(x => x.Id == id).AlterarDataHoraPagamento(dataHoraPagamento);
            context.SaveChanges();
        }

        public void AlterarFormaPagamento(int id, FormaPagamento formaPagamento)
        {
            context.Pagamento.FirstOrDefault(x => x.Id == id).AlterarFormaPagamento(formaPagamento);
            context.SaveChanges();
        }

        public List<Pagamento> SelecionarID(int id)
        {
            return context.Pagamento.Where(x => x.Id == id).ToList();
            
        }
    }
}
