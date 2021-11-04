using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class BeneficioDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Beneficio Converter(BeneficioDto beneficio)
        {
            return Beneficio.GerarBeneficio(beneficio.Nome, beneficio.Descricao);
        }

        public static BeneficioDto CriarBeneficio(Beneficio beneficio)
        {
            BeneficioDto dto = new();
            dto.Nome = beneficio.Nome;
            dto.Descricao = beneficio.Descricao;
            return dto;
        }
    }
}
