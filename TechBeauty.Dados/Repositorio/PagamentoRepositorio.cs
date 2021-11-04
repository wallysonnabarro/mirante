using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dados.Repositorio
{
    public class PagamentoRepositorio
    {
        public List<Pagamento> TabelaPagamento { get; private set; } = new();

        public PagamentoRepositorio()
        {

        }
        public void Incluir(Pagamento pagamento)
        {
            TabelaPagamento.Add(pagamento);
        }
        public void AlterarDataHora(int id, DateTime dataHoraPagamento)
        {
            TabelaPagamento.FirstOrDefault(x => x.Id == id).AlterarDataHora(dataHoraPagamento);
        }

        public void AlterarFormaPagamento(int id, FormaPagamento formaPagamento)
        {
            TabelaPagamento.FirstOrDefault(x => x.Id == id).FormaPagamento(formaPagamento);
        }



        // falta o método troco(dinheiro)

        public Pagamento SelecionarPorId(int id)
        {
            return TabelaPagamento.FirstOrDefault(x => x.Id == id);
        }
        public void Remover(int id)
        {
            TabelaPagamento.Remove(SelecionarPorId(id));
        }
    }
}
