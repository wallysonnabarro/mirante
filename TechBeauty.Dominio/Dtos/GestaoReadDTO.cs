using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dominio.Dtos
{
    class GestaoReadDTO
    {
        public int Id { get; private set; }
        public decimal Salario { get; private set; }
        public decimal Receita { get; private set; }


        public static object Paginar(List<Gestao> gestoes)
        {
            List<GestaoReadDTO> dto = new();
            foreach (var item in gestoes)
            {
                GestaoReadDTO gestaoRead = new();
                gestaoRead.Id = item.Id;
                gestaoRead.Salario = item.Salario;
                gestaoRead.Receita = item.Receita;
                dto.Add(gestaoRead);
            }
            return dto;
        }
    }
}
