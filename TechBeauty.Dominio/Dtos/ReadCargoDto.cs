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
        public string Nome { get; set; }
        public string Descricao { get; set; }

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
