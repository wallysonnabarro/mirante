using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class RegimeContratualDTO
    {
        [StringLength(20, ErrorMessage = "Quantidade máximo de caracteres = 20")]
        [Required(ErrorMessage = "O campo Nome do Regime Contratual é obrigatório!")]
        public string Valor { get; set; }
    }
}
