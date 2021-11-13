using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class ComissaoDTO
    {
        [Required(ErrorMessage = "O campo 'Valor' de comissão é obrigatório!")]
        public decimal Valor { get; set; }
        public int AgendamentoID { get; set; }
       
    }
}
