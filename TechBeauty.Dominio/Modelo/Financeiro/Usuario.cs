using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dominio.Modelo
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Password { get; private set; }
        public Cargo Cargo { get; private set; }
        public Gestao Gestao { get; set; }

        public static Usuario Criar(string nome, string password, Cargo cargo)
        {
            Usuario usuario = new();
            usuario.Nome = nome;
            usuario.Password = password;
            usuario.Cargo = cargo;
            return usuario;
        }
        public void AlterarUsuario(string nome)
        {
            Nome = nome;
        }
        public void AlterarCargo(Cargo cargo)
        {
            Cargo = cargo;
        }
        public void AlterarSenha(string passwaord)
        {
            Password = passwaord;
        }
    }
}
