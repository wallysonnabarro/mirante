using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class TipoContato
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
        public void AtualizarTipoContato(string valor)
        {
            Valor = valor;
        }

    }
}
