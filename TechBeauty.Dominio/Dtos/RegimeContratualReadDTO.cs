using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    class RegimeContratualReadDTO
    {
        public int Id { get;  set; }
        public string Valor { get; set; }


        public static object Paginar(List<RegimeContratual> regimes)
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

    }
}
