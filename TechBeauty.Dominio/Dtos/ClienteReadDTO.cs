using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    class ClienteReadDTO
    {
        public int Id { get; set; }

        public static object Paginar(List<Cliente> clientes)
        {
            List<ClienteReadDTO> dto = new();
            foreach (var item in clientes)
            {
                ClienteReadDTO clienteRead = new();
                clienteRead.Id = item.Id;
                dto.Add(clienteRead);
            }
            return dto;
        }
    }
}
