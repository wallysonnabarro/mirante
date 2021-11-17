using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class ColaboradorAtualizarDto
    {
        public string NomeSocial { get; set; }
        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 100")]
        [Required(ErrorMessage = "O campo Nome do Colaborador é obrigatório!")]
        public string Nome { get; set; }
        [StringLength(11, ErrorMessage = "Quantidade máximo de caracteres = 11")]
        [Required(ErrorMessage = "O campo CPF do Colaborador é obrigatório!")]
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int GeneroId { get; set; }
    }
}
