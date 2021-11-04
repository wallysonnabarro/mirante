using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class GeneroDto
    {
        [StringLength(30, ErrorMessage = "Quantidade máximo de caracteres = 30")]
        [Required(ErrorMessage = "O campo Genero é obrigatório!")]
        public string Valor { get; set; }

        public static GeneroDto CriarGenero(string genero)
        {
            GeneroDto dto = new();
            dto.Valor = genero;
            return dto;
        }
    }
}
