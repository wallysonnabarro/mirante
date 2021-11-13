using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class EnderecoReadDTO
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }

        public static object Paginar(List<Endereco> enderecos)
        {
            List<EnderecoReadDTO> dto = new();
            foreach (var item in enderecos)
            {
                EnderecoReadDTO enderecoRead = new();
                enderecoRead.Id = item.Id;
                enderecoRead.Logradouro = item.Logradouro;
                enderecoRead.Cidade = item.Cidade;
                enderecoRead.UF = item.UF;
                enderecoRead.Bairro = item.Bairro;
                enderecoRead.Cep = item.Cep;
                enderecoRead.Numero = item.Numero;
                enderecoRead.Complemento = item.Complemento;
                dto.Add(enderecoRead);
            }
            return dto;
        }
    }
}
