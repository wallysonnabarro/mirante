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
        private readonly Context context;

        public PagamentoRepositorio()
        {
            context = new();
        }

        public void Incluir(Pagamento pagamento)
        {
            context.Pagamento.Add(pagamento);
            context.SaveChanges();
        }

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

        public Pagamento SelecionarPorId(int id)
        {
            return context.Pagamento.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Pagamento.Remove(SelecionarPorId(id));
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
