using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ColaboradorReadDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public int GeneroId { get; set; }
        public ICollection<ContatoReadDTO> Contatos { get; set; }

        public static ColaboradorReadDTO Unico(Colaborador colaborador, Endereco endereco, List<ContatoReadDTO> contatoRead)
        {
            ColaboradorReadDTO dto = new();
            dto.Bairro = endereco.Bairro;
            dto.Logradouro = endereco.Logradouro;
            dto.Cep = endereco.Cep;
            dto.Cidade = endereco.Cidade;
            dto.Complemento = endereco.Complemento;
            dto.CPF = colaborador.CPF;
            dto.DataNascimento = colaborador.DataNascimento;
            dto.GeneroId = colaborador.GeneroId;
            dto.Id = colaborador.Id;
            dto.Nome = colaborador.Nome;
            dto.Numero = endereco.Numero;
            dto.UF = endereco.UF;
            dto.Contatos = contatoRead;
            return dto;
        }
    }
}
