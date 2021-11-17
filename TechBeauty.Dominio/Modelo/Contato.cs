using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Contato : IEntity
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public int TipoId { get; set; }
        public TipoContato Tipo { get; private set; }//navegação
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        
        public static Contato Criar(int id ,ContatoDTO contatoDto)
        {
            Contato contato = new();
            contato.TipoId = contatoDto.TipoID;
            contato.Valor = contatoDto.Valor;
            contato.PessoaId = id;
            return contato;
        }

        public static Contato AlterarContato(int id, ContatoDTO contato)
        {
            Contato dto = new();
            dto.TipoId = contato.TipoID;
            dto.Valor = contato.Valor;
            dto.PessoaId = id;
            return dto;
        }

        public static List<ContatoReadDTO> ConverteContato(List<Contato> contatos)
        {
            List<ContatoReadDTO> contatosRead = new();
            foreach (var item in contatos)
            {
                ContatoReadDTO read = new();
                read.Id = item.Id;
                read.Valor = item.Valor;
                contatosRead.Add(read);
            }
            return contatosRead;
        }
    }
}
