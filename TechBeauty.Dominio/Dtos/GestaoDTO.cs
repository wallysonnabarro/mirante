using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class GestaoDTO
    {
        [StringLength(5, ErrorMessage = "Quantidade máximo de caracteres = 5")]
        [Required(ErrorMessage = "O campo 'Salario' de gestao é obrigatório!")]
        public decimal Salario { get; set; }

        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'Receita' de gestao é obrigatório!")]
        public decimal Receita { get;  set; }

        public static GestaoDTO CriarGestao(GestaoDTO gestao)
        {
            GestaoDTO dto = new();
            dto.Salario = gestao.Salario;
            dto.Receita = gestao.Receita;
            return dto;
        }
    }
}
