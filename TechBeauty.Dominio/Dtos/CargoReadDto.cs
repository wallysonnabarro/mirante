using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class CargoReadDTO
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public static List<CargoReadDTO> Paginar(List<Cargo> cargo)
        {
            List<CargoReadDTO> dtos = new();
            foreach (var item in cargo)
            {
                CargoReadDTO dto = new();
                dto.Id = item.Id;
                dto.Nome = item.Nome;
                dto.Descricao = item.Descricao;
                dtos.Add(dto);
            }
            return dtos;
        }

        public static object Selecionar(Cargo cargo)
        {
            CargoReadDTO dto = new();
            dto.Id = cargo.Id;
            dto.Nome = cargo.Nome;
            dto.Descricao = cargo.Descricao;
            return dto;
        }
    }
}

