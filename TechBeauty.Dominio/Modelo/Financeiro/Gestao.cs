using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    public class Gestao : IEntity
    {
        public int Id { get; private set; }
        public Usuario Usuario { get; private set; }//será populada
        public List<EspacoCliente> EspacoClientes { get; private set; }
        public decimal Salario { get; private set; }
        public List<Caixa> Caixas { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public decimal Receita { get; private set; }

        public Gestao Criar(Usuario usuario, List<EspacoCliente> espacoCliente, decimal salario)
        {
            Gestao gestao = new();
            gestao.Usuario = usuario;
            gestao.EspacoClientes = espacoCliente;
            gestao.Salario = salario;
            return gestao;
        }

        public void RegistrarLucroMensal(decimal lucroMensal)
        {
            Receita = lucroMensal;
        }

        
        public decimal ReceitaMensal(decimal receita)
        {
            return 0;
        }

        public bool ValidarAcesso(Usuario usuario)
        {
            return true;
        }
    }
}
