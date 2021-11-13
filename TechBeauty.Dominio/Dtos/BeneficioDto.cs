using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class BeneficioDto
    {
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo Nome do beneficio é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(150, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo descrição do beneficio é obrigatório!")]
        public string Descricao { get; set; }
    }
}
