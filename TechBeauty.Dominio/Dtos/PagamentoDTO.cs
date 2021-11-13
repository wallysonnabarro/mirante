using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class PagamentoDTO
    {
        [Required(ErrorMessage = "O campo 'ValorRecebido' do pagamento é obrigatório!")]
        public decimal ValorRecebido { get; set; }
        public int OrdemServicoID { get; set; }
        public int FormaPagamentoID { get; set; }
    }
}
