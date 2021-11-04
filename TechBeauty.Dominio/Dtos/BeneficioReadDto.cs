using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class BeneficioReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public static BeneficioReadDto CriarBeneficio(Beneficio beneficio)
        {
            BeneficioReadDto dto = new();
            dto.Id = beneficio.Id;
            dto.Nome = beneficio.Nome;
            dto.Descricao = beneficio.Descricao;
            return dto;
        }
    }
}
