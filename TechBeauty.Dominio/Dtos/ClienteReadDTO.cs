using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ClienteReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public static object Paginar(List<Cliente> clientes)
        {
            List<ClienteReadDto> dto = new();
            foreach (var item in clientes)
            {
                ClienteReadDto clienteRead = new();
                clienteRead.Id = item.Id;
                clienteRead.Nome = item.Nome;
                clienteRead.DataNascimento = item.DataNascimento;
                clienteRead.Cpf = item.CPF;
                dto.Add(clienteRead);
            }
            return dto;
        }

        public static ClienteReadDto Cliente(Cliente cliente)
        {
            ClienteReadDto read = new();
            read.Id = cliente.Id;
            read.Nome = cliente.Nome;
            read.DataNascimento = cliente.DataNascimento;
            read.Cpf = cliente.CPF;
            return read;
        }
    }
}
