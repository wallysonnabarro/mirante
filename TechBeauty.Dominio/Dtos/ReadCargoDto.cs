using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ReadCargoDto
    {
        public int Codigo { get; set; }
        [StringLength(100, ErrorMessage = "Quantidade máximo de caracteres = 100")]
        [Required(ErrorMessage = "O campo Nome do cargo é obrigatório!")]
        public string Nome { get; set; }
        [StringLength(150, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo descrição do cargo é obrigatório!")]
        public string Descricao { get; set; }

        public ReadCargoDto()
        {

        }

        public ReadCargoDto(Cargo cargo)
        {
            Codigo = cargo.Id;
            Nome = cargo.Nome;
            Descricao = cargo.Descricao;
        }

        public static List<ReadCargoDto> Colecao(List<Cargo> cargos)
        {
            List<ReadCargoDto> readCargoDto = new();
            foreach (var item in cargos)
            {
                readCargoDto.Add(new ReadCargoDto(item));
            }
            return readCargoDto;
        }
    }
}
