using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ColaboradorDTO
    {
        [StringLength(150, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string NomeSocial { get; set; }
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string CarteiraTrabalho { get; set; }
        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 100")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Nome { get; set; }
        [StringLength(11, ErrorMessage = "Quantidade máximo de caracteres = 11")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        [StringLength(150, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Logradouro { get; set; }
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Cidade { get; set; }
        [StringLength(2, ErrorMessage = "Quantidade máximo de caracteres = 2")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string UF { get; set; }
        [StringLength(15, ErrorMessage = "Quantidade máximo de caracteres = 15")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Numero { get; set; }
        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 100")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Complemento { get; set; }
        [StringLength(8, ErrorMessage = "Quantidade máximo de caracteres = 8")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Cep { get; set; }
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo Nome social do Colaborador é obrigatório!")]
        public string Bairro { get; set; }
        public int GeneroId { get; set; }
        public int EscalaId { get; set; }


    }
}
