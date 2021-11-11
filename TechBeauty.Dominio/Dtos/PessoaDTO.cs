using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class PessoaDTO
    {
        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo Nome do Pessoa é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(11, ErrorMessage = "Quantidade máximo de caracteres = 11")]
        [Required(ErrorMessage = "O campo CPF da Pessoa é obrigatório!")]
        public string CPF { get; set; }

        
        [Required(ErrorMessage = "O campo DataNascimento da Pessoa é obrigatório!")]
        public DateTime DataNascimento { get; set; }

        public static PessoaDTO CriarPessoa(PessoaDTO pessoa)
        {
            PessoaDTO dto = new();
            dto.Nome = pessoa.Nome;
            dto.CPF = pessoa.CPF;
            dto.DataNascimento = pessoa.DataNascimento;
            return dto;
        }
    }
}
