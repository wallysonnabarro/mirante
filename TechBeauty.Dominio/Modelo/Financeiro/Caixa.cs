using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {
        public int Id { get; private set; }
        public decimal SaldoInicial { get; private set; }
        public decimal SaldoFinalCaixa  { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraFechamento { get; private set; }
        public List<Pagamento> Pagamentos { get; private set; }//Navegaçãos, não será populada
        public Gestao Gestao { get; private set; }//Será populada
        public decimal LucroDiario { get; private set; }
        public decimal RetiradasDiarias { get; private set; }

        public static Caixa AbrirCaixa(decimal saldoInicial)
        {
            Caixa caixa = new();
            caixa.SaldoInicial = saldoInicial;
            caixa.DataHoraCriacao = DateTime.Now;
            return caixa;
        }

        public void  FecharCaixa(List<Pagamento> pagamentos)
        {
            DataHoraFechamento = DateTime.Now;

            decimal valor = 0;

            foreach (var item in pagamentos)
            {
                valor += item.OrdemServico.PrecoTotal;
            }

            LucroDiario = valor - SaldoInicial;
            SaldoFinalCaixa = valor + SaldoInicial;
        }

        public void RegistrarRetiradasDiarias(decimal retirada)
        {
            RetiradasDiarias += retirada;
        }
    }
}
