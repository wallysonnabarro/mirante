using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class ColaboradorDTO
    {
        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string NomeSocial { get; set; }


        public static ColaboradorDTO CriarColaborador(ColaboradorDTO colaborador)
        {
            ColaboradorDTO dto = new();
            dto.NomeSocial = colaborador.NomeSocial;
            return dto;
        }
    }
}
