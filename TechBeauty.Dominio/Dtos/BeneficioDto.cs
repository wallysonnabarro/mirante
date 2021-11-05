using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class Beneficio
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Modelo.Beneficio Converter(Beneficio beneficio)
        {
            return Modelo.Beneficio.GerarBeneficio(beneficio.Nome, beneficio.Descricao);
        }

        public static Beneficio CriarBeneficio(Modelo.Beneficio beneficio)
        {
            Beneficio dto = new();
            dto.Nome = beneficio.Nome;
            dto.Descricao = beneficio.Descricao;
            return dto;
        }
    }
}
