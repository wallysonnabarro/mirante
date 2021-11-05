using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Contato : IEntity
    {
        public Pessoa Pessoa { get; set; }
        public int Id { get; private set; }
        public TipoContato Tipo { get; private set; }
        public string Valor { get; private set; }
        
        public static Contato Criar(Contato contatoDto)
        {
            Contato contato = new();
            contato.Tipo = contatoDto.Tipo;
            contato.Valor = contatoDto.Valor;

            return contato;
        }
        public void AlterarContato(Contato contatoDto)
        {
            Tipo = contatoDto.Tipo;
            Valor = contatoDto.Valor;
        }
      
    
    }
}
