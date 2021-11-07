using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class UsuarioRepositorio : RepositorioBase<Usuario>
    {
        public bool ValidarUsuario(Usuario usuario)
        {
            if (context.Usuario.FirstOrDefault(x => x.Nome == usuario.Nome & x.Password == usuario.Password) != null)
            {
                return true;
            }
            return false;
        }
        

        public void AlterarSenhaUsuario(int id, string senha)
        {
            context.Usuario.FirstOrDefault(x => x.Id == id).AlterarSenha(senha);
            context.SaveChanges();
        }

        public void AlterarCargoUsuario(int id, Cargo cargo)
        {
            context.Usuario.FirstOrDefault(x => x.Id == id).AlterarCargo(cargo);
            context.SaveChanges();
        }
  
    }
}
