using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
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

        public static Contato Criar(ContatoDTO contato)
        {
            throw new NotImplementedException();
        }

        public static Contato AlterarContato(ContatoDTO contato, TipoContato tipo)
        {
            Contato dto = new();
            dto.Tipo = tipo;
            dto.Valor = contato.Valor;
            return dto;
        }


    }
}
