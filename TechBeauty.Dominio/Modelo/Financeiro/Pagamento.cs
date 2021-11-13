using System;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Pagamento : IEntity
    {
        public int Id { get; private set; }
        public OrdemServico OrdemServico { get; private set; } //Será populada 
        public Caixa Caixa { get; private set; }//Será populada 
        public DateTime DataHoraPagamento { get; private set; }
        public decimal ValorRecebido { get; private set; }
        public decimal? Troco { get; private set; }
        public FormaPagamento Forma { get; private set; }


        public static Pagamento Criar(PagamentoDTO pagamentoDto, OrdemServico os)
        {
            Pagamento pagamento = new();
            pagamento.OrdemServico= os;
            pagamento.DataHoraPagamento = DateTime.Now;
            pagamento.ValorRecebido = pagamentoDto.ValorRecebido;
            pagamento.Forma = (FormaPagamento)pagamentoDto.FormaPagamentoID;
            return pagamento;
        }

        public void AlterarDataHoraPagamento(DateTime dataHoraPagamento)
        {
            DataHoraPagamento = dataHoraPagamento;
        }

        public void AlterarFormaPagamento(FormaPagamento formaPagamento)
        {
            Forma = formaPagamento;
        }

        public void TrocoDinheiro()
        {
            Troco = ValorRecebido - OrdemServico.PrecoTotal;
        }

        public static Pagamento Alterar(PagamentoDTO pagamentoDto, OrdemServico os, int id)
        {
            Pagamento pagamento = new();
            pagamento.Id = id;
            pagamento.OrdemServico = os;
            pagamento.DataHoraPagamento = DateTime.Now;
            pagamento.ValorRecebido = pagamentoDto.ValorRecebido;
            pagamento.Forma = (FormaPagamento)pagamentoDto.FormaPagamentoID;
            return pagamento;
        }
    }
}
