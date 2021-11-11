using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    class UsuarioReadDTO
    {
        public int Id { get; set; }
        public string Nome { get;  set; }
        public string Password { get; set; }

        public static object Paginar(List<Usuario> usuarios)
        {
            List<UsuarioReadDTO> dto = new();
            foreach (var item in usuarios)
            {
                UsuarioReadDTO usuarioRead = new();
                usuarioRead.Id = item.Id;
                usuarioRead.Nome = item.Nome;
                usuarioRead.Password = item.Password;
                dto.Add(usuarioRead);
            }
            return dto;
        }
    }
}
