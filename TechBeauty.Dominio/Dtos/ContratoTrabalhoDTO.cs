using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class ContratoTrabalhoDTO
    {
        [StringLength(14, ErrorMessage = "Quantidade máximo de caracteres = 14")]
        [Required(ErrorMessage = "O campo 'CnpjCtps' do contrato de trabalho é obrigatório!")]
        public string CnpjCtps { get; set; }
        [Required(ErrorMessage = "O campo 'DataEntrada' do contrato de trabalho é obrigatório!")]
        public DateTime DataEntrada { get; set; }
        public int RegimeId { get; set; }
        public List<int> CargosId { get; set; }
        public int ColaboradorId { get; set; }
        [Required(ErrorMessage = "O campo 'PorcentagemComissao' do contrato de trabalho é obrigatório!")]
        public decimal ProcentagemComissao { get; set; }

        [Required(ErrorMessage = "O campo salário é obrigatório!")]
        public decimal Salario { get; set; }
    }
}
