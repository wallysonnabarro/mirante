using System.Collections.Generic;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class TipoContato : IEntity
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public List<Contato> Contatos { get; private set; }

        public static TipoContato Criar(string valor)
        {
            TipoContato tipoContato = new();
            
            tipoContato.Valor = valor;

            return tipoContato;
        }
        public static TipoContato AtualizarTipoContato(string valor, int id)
        {
            TipoContato tipo = Criar(valor);
            tipo.Id = id;
            return tipo;
        }

    }
}
