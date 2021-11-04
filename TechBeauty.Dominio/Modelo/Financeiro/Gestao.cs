using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    public class Gestao
    {
        public int Id { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<EspacoCliente> EspacoClientes { get; set; }
        public decimal Salario { get; set; }
        public List<Caixa> Caixas { get; set; }
        public Colaborador Colaborador { get; set; }
        public decimal Receita { get; set; }

        public Gestao Criar(List<Usuario> usuarios, List<EspacoCliente> espacoCliente, decimal salario)
        {
            Gestao gestao = new();
            gestao.Usuarios = usuarios;
            gestao.EspacoClientes = espacoCliente;
            gestao.Salario = salario;
            return gestao;
        }

        public decimal LucroMensal(List<Caixa> caixas)
        {
            return 0;
        }

        public decimal ComissaoTotalColaborador(Colaborador colaborador)
        {
            return 0;
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
