using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class UsuarioRepositorio
    {
        private readonly Context context;

        public UsuarioRepositorio()
        {
            context = new();
        }

        public void IncluirUsuario(Usuario usuario)
        {
            context.Usuario.Add(usuario);
            context.SaveChanges();
        }

        public void AlterarUsuario(int id, string usuario)
        {
            context.Usuario.FirstOrDefault(x => x.Id == id).AlterarUsuario(usuario);
            context.SaveChanges();
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

        public void ExcluirUsuario(int id)
        {
            context.Usuario.Remove(context.Usuario.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public Usuario SelecionarUsuario(int id)
        {
            return context.Usuario.FirstOrDefault(x => x.Id == id);
        }

        public List<Usuario> Tabela()
        {
            return context.Usuario.ToList();
        }
    }
}
