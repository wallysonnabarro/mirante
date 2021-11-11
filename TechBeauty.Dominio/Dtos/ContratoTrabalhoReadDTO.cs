using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ContratoTrabalhoReadDTO
    {
        public int Id { get; private set; }
        public string CnpjCTPS { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }

        public static object Paginar(List<ContratoTrabalho> contratos)
        {
            List<ContratoTrabalhoReadDTO> dto = new();
            foreach (var item in contratos)
            {
                ContratoTrabalhoReadDTO contratoRead = new();
                contratoRead.Id = item.Id;
                contratoRead.CnpjCTPS = item.CnpjCTPS;
                contratoRead.DataEntrada = item.DataEntrada;
                contratoRead.DataDesligamento = item.DataDesligamento;
                dto.Add(contratoRead);
            }
            return dto;
        }

    }
}
