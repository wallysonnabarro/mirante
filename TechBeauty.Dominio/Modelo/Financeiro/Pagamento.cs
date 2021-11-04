using System;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class Pagamento
    {
        public int Id { get; private set; }
        public OrdemServico OrdemServico { get; private set; } //Será populada 
        public Caixa Caixa { get; private set; }//Será populada 
        public DateTime DataHoraPagamento { get; private set; }
        public decimal ValorRecebido { get; private set; }
        public decimal? Troco { get; private set; }
        public FormaPagamento Forma { get; set; }

        public static Pagamento Criar(Pagamento pagamentoDto)
        {
            Pagamento pagamento = new();
            pagamento.OrdemServico = pagamentoDto.OrdemServico;
            pagamento.DataHoraPagamento = pagamentoDto.DataHoraPagamento;
            pagamento.ValorRecebido = pagamentoDto.ValorRecebido;
            return pagamento;
        }

        public void AlterarDataHora(DateTime dataHoraPagamento)
        {
            DataHoraPagamento = dataHoraPagamento;
        }

        public void FormaPagamento(FormaPagamento formaPagamento)
        {
            Forma = formaPagamento;
        }

        public void TrocoDinheiro()
        {
            Troco = ValorRecebido - OrdemServico.PrecoTotal;
        }

    }
}
