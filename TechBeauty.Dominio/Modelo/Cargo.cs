using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Salario { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<ContratoTrabalho> ContratosTrabalhos { get; set; }


        public static Cargo criarCargo(string nome, string descricao, decimal salario)
        {
            Cargo cargo = new();
            cargo.Nome = nome;
            cargo.Descricao = descricao;
            cargo.Salario = salario;
            return cargo;
        }
        public void AlterarCargo(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

    }
}
