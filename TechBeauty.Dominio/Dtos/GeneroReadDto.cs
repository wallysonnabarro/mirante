using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class GeneroReadDto
    {
        public int Id { get; set; }
        public string Valor { get; set; }


        public GeneroReadDto(Genero genero)
        {
            Id = genero.Id;
            Valor = genero.Valor;
        }

        public static List<GeneroReadDto> Paginar(List<Genero> generos)
        {
            List<GeneroReadDto> dtos = new();
            foreach (var genero in generos)
            {
                dtos.Add(new GeneroReadDto(genero));
            }
            return dtos;
        }

    }
}
