using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>
    {
        public override int Incluir(Usuario entity)
        {
            if (!context.Usuario.Any(u => u.Nome == entity.Nome))
            {
                return base.Incluir(entity);
            }
            throw new ArgumentException();
        }

        public bool ValidarUsuario(UsuarioDTO usuario)
        {
            if (context.Usuario.Any(x => x.Nome == usuario.Nome & x.Password == usuario.Password))
            {
                return true;
            }
            throw new ArgumentException($"Usuario {usuario.Nome} ou senha {usuario.Password}");
        }


        public void AlterarSenha(int id, string senha)
        {
            context.Usuario.FirstOrDefault(x => x.Id == id).AlterarSenha(senha);
            context.SaveChanges();
        }

        public void AlterarCargoUsuario(int id, int cargoId)
        {
            if (context.Usuario.Any(u => u.Id == id) && context.Cargo.Any(c => c.Id == cargoId))
            {
                var cargo = new CargoRepositorio().Selecionar(cargoId);
                context.Usuario.FirstOrDefault(x => x.Id == id).AlterarCargo(cargo);
                context.SaveChanges();
            }
            throw new ArgumentException($"Código do usuário ou cargo incorreta!");
        }

        public void AtualizarUsuario(int id, string user)
        {
            if (context.Usuario.Any(u => u.Id == id))
            {
                context.Usuario.FirstOrDefault(u => u.Id == id).AlterarUsuario(user);
                context.SaveChanges();
            }
            throw new ArgumentException($"Código {id} incorreta!", nameof(id));
        }
    }
}
