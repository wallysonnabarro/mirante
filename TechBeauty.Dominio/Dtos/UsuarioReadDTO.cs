using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class UsuarioReadDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static UsuarioReadDTO Convert(Usuario usuario)
        {
            UsuarioReadDTO usuarioRead = new();
            usuarioRead.Id = usuario.Id;
            usuarioRead.Nome = usuario.Nome;
            return usuarioRead;
        }

        public static List<UsuarioReadDTO> Paginar(List<Usuario> usuarios)
        {
            List<UsuarioReadDTO> dtos = new();
            foreach (var item in usuarios)
            {
                dtos.Add(Convert(item));
            }
            return dtos;
        }
    }
}
