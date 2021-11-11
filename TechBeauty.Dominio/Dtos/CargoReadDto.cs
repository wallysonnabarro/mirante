using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class CargoReadDto
    {

        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Salario { get; private set; }

        public static List<CargoReadDto> Paginar(List<Cargo> cargos)
        {
            List<CargoReadDto> dtos = new();
            foreach (var item in cargos)
            {
                CargoReadDto dto = new();
                dto.Nome = item.Nome;
                dto.Descricao = item.Descricao;
                dto.Salario = item.Salario;
                dtos.Add(dto);
            }
            return dtos;
        }
    }
}

