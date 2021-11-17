using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Financeiro;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Usuario : IEntity
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Password { get; private set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; private set; }
        public List<Gestao> Gestao { get; set; }//Navegação, não será populada
        public List<Caixa> Caixa { get; set; }
        public static Usuario Criar(UsuarioDTO dto)
        {
            Usuario usuario = new();
            usuario.Nome = dto.Nome;
            usuario.Password = dto.Password;
            usuario.CargoId = dto.CargoId;
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
