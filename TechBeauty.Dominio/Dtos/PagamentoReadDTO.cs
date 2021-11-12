using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class PagamentoReadDTO
    {
        public int Id { get;  set; }
        public DateTime DataHoraPagamento { get;  set; }
        public decimal ValorRecebido { get;  set; }
        public decimal? Troco { get;  set; }


        public static object Paginar(List<Pagamento> pagamentos)
        {
            List<PagamentoReadDTO> dto = new();
            foreach (var item in pagamentos)
            {
                PagamentoReadDTO pagamentoRead = new();
                pagamentoRead.Id = item.Id;
                pagamentoRead.DataHoraPagamento = item.DataHoraPagamento;
                pagamentoRead.ValorRecebido = item.ValorRecebido;
                pagamentoRead.Troco = item.Troco;
                dto.Add(pagamentoRead);
            }
            return dto;
        }
    }
}
