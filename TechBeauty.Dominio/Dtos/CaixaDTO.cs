using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class CaixaDTO
    {
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'SaldoInicial' do caixa é obrigatório!")]
        public decimal SaldoInicial { get; set; }

        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'SaldoFinalCaixa' do caixa é obrigatório!")]
        public decimal SaldoFinalCaixa { get; set; }

        
        [Required(ErrorMessage = "O campo 'DataHoraCriacao' do caixa é obrigatório!")]
        public DateTime DataHoraCriacao { get; set; }

        
        [Required(ErrorMessage = "O campo 'DataHoraFechamento' do caixa é obrigatório!")]
        public DateTime DataHoraFechamento { get; set; }

        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'LucroDiario' do caixa é obrigatório!")]
        public decimal LucroDiario { get; set; }

        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'RetiradasDiarias' do caixa é obrigatório!")]
        public decimal RetiradasDiarias { get; set; }

        public static CaixaDTO CriarCaixa(CaixaDTO caixa)
        {
            CaixaDTO dto = new();
            dto.SaldoInicial= caixa.SaldoInicial;
            dto.SaldoFinalCaixa = caixa.SaldoFinalCaixa;
            dto.DataHoraCriacao = caixa.DataHoraCriacao;
            dto.DataHoraFechamento = caixa.DataHoraFechamento;
            dto.LucroDiario = caixa.LucroDiario;
            dto.RetiradasDiarias = caixa.RetiradasDiarias;
            return dto;
        }


    }
}
