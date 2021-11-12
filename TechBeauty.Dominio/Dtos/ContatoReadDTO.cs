using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ContatoReadDTO
    {
        public int Id { get; set; }
        public string Valor { get; set; }

        public static object Paginar(List<Contato> contatos)
        {
            List<ContatoReadDTO> dto = new();
            foreach (var item in contatos)
            {
                ContatoReadDTO contatoRead = new();
                contatoRead.Id = item.Id;
                contatoRead.Valor = item.Valor;
                dto.Add(contatoRead);
            }
            return dto;
        }

    }
}
