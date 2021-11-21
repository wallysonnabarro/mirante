using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dominio.Dtos
{
    public class ComissaoReadDTO
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }

        public static List<ComissaoReadDTO> Paginar(List<Comissao> comissoes)
        {
            List<ComissaoReadDTO> dto = new();
            foreach (var item in comissoes)
            {
                ComissaoReadDTO comissaoRead = new();
                comissaoRead.Id = item.Id;
                comissaoRead.Valor = item.Valor;                
                dto.Add(comissaoRead);
            }
            return dto;
        }
    }
}
