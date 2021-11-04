using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class CargoDto
    {
        [StringLength(100, ErrorMessage ="Quantidade máximo de caracteres = 100")]
        [Required(ErrorMessage = "O campo Nome do cargo é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(150, ErrorMessage = "Quantidade máximo de caracteres = 150")]
        [Required(ErrorMessage = "O campo descrição do cargo é obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo salário é obrigatório!")]
        public decimal Salario { get; set; }


        public static CargoDto Criar(Cargo cargo)
        {
            CargoDto cargoDto = new();
            cargoDto.Nome = cargo.Nome;
            cargoDto.Descricao = cargo.Descricao;
            cargoDto.Salario = cargo.Salario;
            return cargoDto;
        }
    }
}
