using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ServicoDTO
    {
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo Nome do Servico é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Preco do Servico é obrigatório!")]
        public decimal Preco { get; set; }
        [StringLength(150, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo Descrição do Servico é obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo DuracaoEmMin do Servico é obrigatório!")]
        public int DuracaoEmMin { get; set; }


        public static ServicoDTO CriarServico(Servico servico)
        {
            ServicoDTO dto = new();
            dto.Nome = servico.Nome;
            dto.Preco = servico.Preco;
            dto.Descricao = servico.Descricao;
            dto.DuracaoEmMin = servico.DuracaoEmMin;
            return dto;
        }
    }
}
