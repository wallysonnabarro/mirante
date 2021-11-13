using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class RegimeContratualReadDTO
    {
        public int Id { get;  set; }
        public string Valor { get; set; }

        public static List<RegimeContratualReadDTO> Paginar(List<RegimeContratual> regimes)
        {
            List<RegimeContratualReadDTO> dto = new();
            foreach (var item in regimes)
            {
                RegimeContratualReadDTO regimeContratualRead = new();
                regimeContratualRead.Id = item.Id;
                regimeContratualRead.Valor = item.Valor;
                dto.Add(regimeContratualRead);
            }
            return dto;
        }

        public static RegimeContratualReadDTO Converte(RegimeContratual regimeContratual)
        {
            RegimeContratualReadDTO dto = new();
            dto.Id = regimeContratual.Id;
            dto.Valor = regimeContratual.Valor;
            return dto;
        }
    }
}
