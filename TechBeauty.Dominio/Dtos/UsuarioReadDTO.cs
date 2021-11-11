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
        public string Nome { get; set; }

        public static UsuarioReadDTO Convert(Usuario usuario)
        {
            UsuarioReadDTO usuarioRead = new();
            usuarioRead.Id = usuario.Id;
            usuarioRead.Nome = usuario.Nome;
            return usuarioRead;
        }
    }
}
