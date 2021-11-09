using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dominio.Dtos
{
    public class BeneficioReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public static object Paginar(List<Beneficio> beneficios)
        {
            List<BeneficioReadDto> dto = new();
            foreach (var beneficio in beneficios)
            {
                BeneficioReadDto beneficioRead = new();
                beneficioRead.Id = beneficio.Id;
                beneficioRead.Nome = beneficio.Nome;
                beneficioRead.Descricao = beneficio.Descricao;
                dto.Add(beneficioRead);
            }
            return dto;
        }
    }
}
