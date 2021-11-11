using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class PagamentoDTO
    {
        [StringLength(20, ErrorMessage = "Quantidade máximo de caracteres = 20")]
        [Required(ErrorMessage = "O campo 'DataHoraPagamento' de pagamento é obrigatório!")]
        public DateTime DataHoraPagamento { get; set; }

        [StringLength(20, ErrorMessage = "Quantidade máximo de caracteres = 20")]
        [Required(ErrorMessage = "O campo 'ValorRecebido' do pagamento é obrigatório!")]
        public decimal ValorRecebido { get; set; }

        [StringLength(20, ErrorMessage = "Quantidade máximo de caracteres = 20")]
        [Required(ErrorMessage = "O campo 'Troco' do pagamento é obrigatório!")]
        public decimal? Troco { get; set; }

        public static PagamentoDTO CriarPagamento(PagamentoDTO pagamento)
        {
            PagamentoDTO dto = new();
            dto.DataHoraPagamento = pagamento.DataHoraPagamento;
            dto.ValorRecebido = pagamento.ValorRecebido;
            
            return dto;
        }
    }
}
