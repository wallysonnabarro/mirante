using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class EnderecoDTO
    {
        [StringLength(7, ErrorMessage = "Quantidade máximo de caracteres = 7")]
        [Required(ErrorMessage = "O campo Número do Endereco é obrigatório!")]
        public string Numero { get; set; }

        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 100")]
        [Required(ErrorMessage = "O campo Complemento do Endereco é obrigatório!")]
        public string Complemento { get; set; }

        [StringLength(8, ErrorMessage = "Quantidade máximo de caracteres = 8")]
        [Required(ErrorMessage = "O campo Cep do Endereco é obrigatório!")]
        public string Cep { get; set; }


        public static EnderecoDTO CriarEndereco(EnderecoDTO endereco)
        {
            EnderecoDTO dto = new();
            dto.Numero = endereco.Numero;
            dto.Complemento = endereco.Complemento;
            dto.Cep = endereco.Cep;
            return dto;
        }
    }
}

