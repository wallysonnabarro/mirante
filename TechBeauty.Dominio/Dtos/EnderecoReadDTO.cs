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
        public int ID { get; set; }
        public string Numero { get;  set; } 
        public string Complemento { get;  set; } 
        public string Cep { get;  set; } 

        public static object Paginar(List<Endereco> enderecos)
        {
            List<EnderecoReadDTO> dto = new();
            foreach (var item in enderecos)
            {
                EnderecoReadDTO enderecoRead = new();
                enderecoRead.ID = item.Id;
                enderecoRead.Cep = item.Cep;
                enderecoRead.Numero = item.Numero;
                enderecoRead.Complemento = item.Complemento;
                dto.Add(enderecoRead);
            }
            return dto;
        }
    }
}
