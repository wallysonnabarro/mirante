using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class TipoContatoReadDto
    {
        public int Id { get; set; }
        public string Valor { get; set; }

        public TipoContatoReadDto()
        {

        }
        public TipoContatoReadDto(TipoContato tipoContato)
        {
            Id = tipoContato.Id;
            Valor = tipoContato.Valor;
        }

        public static object Colecao(List<TipoContato> tipoContatos)
        {
            List<TipoContatoReadDto> dtos = new();
            foreach (var tipo in tipoContatos)
            {
                dtos.Add(new TipoContatoReadDto(tipo));
            }
            return dtos;
        }
    }
}
