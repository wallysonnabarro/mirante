using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class ComissaoDTO
    {
        [StringLength(5, ErrorMessage = "Quantidade máximo de caracteres = 5")]
        [Required(ErrorMessage = "O campo 'Valor' de comissão é obrigatório!")]
        public decimal Valor { get; set; }


        public static ComissaoDTO CriaComissaoo(ComissaoDTO comissao)
        {
            ComissaoDTO dto = new();
            dto.Valor = comissao.Valor;
            return dto;
        }
    }
}
