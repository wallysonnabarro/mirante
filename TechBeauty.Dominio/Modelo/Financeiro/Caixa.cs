using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Modelo.Financeiro;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa : IEntity
    {
        public int Id { get; private set; }
        public decimal SaldoInicial { get; private set; }
        public decimal SaldoFinalCaixa  { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraFechamento { get; private set; }
        public List<Pagamento> Pagamentos { get; private set; }//Navegaçãos, não será populada
        public decimal LucroDiario { get; private set; }
        public decimal RetiradasDiarias { get; private set; }
        public Usuario Usuario { get; set; }


        public static Caixa AbrirCaixa(decimal saldoInicial, Usuario usuario)
        {
            Caixa caixa = new();
            caixa.SaldoInicial = saldoInicial;
            caixa.DataHoraCriacao = DateTime.Now;
            caixa.Usuario = usuario;
            return caixa;
        }

        public static Caixa FecharCaixaPagamento(List<Pagamento> pagamentos, int id)
        {
            Caixa caixa = new();
            caixa.DataHoraFechamento = DateTime.Now;
            caixa.Id = id;
            decimal valor = 0;

            foreach (var item in pagamentos)
            {
                valor += item.OrdemServico.PrecoTotal;
            }

            caixa.LucroDiario = valor - caixa.SaldoInicial;
            caixa.SaldoFinalCaixa = valor + caixa.SaldoInicial;

            return caixa;
        }

        public void RegistrarRetiradasDiarias(decimal retirada)
        {
            RetiradasDiarias += retirada;
        }
    }
}
