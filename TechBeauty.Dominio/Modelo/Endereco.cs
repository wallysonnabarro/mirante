using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco : IEntity
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string  Cidade { get; private set; }
        public string UF { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public ICollection<Colaborador> Colaboradores { get; set; }


        public static Endereco Criar(ColaboradorDTO dto)
        {
            Endereco endereco = new();
            endereco.Logradouro = dto.Logradouro;
            endereco.Cidade = dto.Cidade;
            endereco.UF = dto.UF;
            endereco.Numero = dto.Numero;
            endereco.Complemento = dto.Complemento;
            endereco.Cep = dto.Cep;
            endereco.Bairro = dto.Bairro;
            return endereco;
        }
        public void AlterarEndereco(Endereco endereco)
        {
            
            Logradouro = endereco.Logradouro;
            Cidade = endereco.Cidade;
            UF = endereco.UF;
            Numero = endereco.Numero;
            Complemento = endereco.Complemento;
            Cep = endereco.Cep;
            Bairro = endereco.Bairro;
        }

        public static Endereco Aterar(EnderecoReadDTO dto)
        {
            Endereco endereco = new();
            endereco.Id = dto.Id;
            endereco.Logradouro = dto.Logradouro;
            endereco.Cidade = dto.Cidade;
            endereco.Bairro = dto.Bairro;
            endereco.Cep = dto.Cep;
            endereco.Complemento = dto.Complemento;
            endereco.UF = dto.UF;
            endereco.Numero = dto.Numero;
            return endereco;
        }
    }
}
