using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Servico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public int DuracaoEmMin { get; private set; }

        public List<Agendamento> Agendamentos { get; set; }
        
        public List<Colaborador> Colaboradores { get; set; }
       

        public static Servico Criar(string nome, decimal preco, string descricao, int duracaoEmMin)
        {
            Servico servico = new Servico();
            
            servico.Nome = nome;
            servico.Preco = preco;
            servico.Descricao = descricao;
            servico.DuracaoEmMin = duracaoEmMin;
            return servico;
        }
        public void ModificarServico(Servico servico)
        {
            Nome = servico.Nome;
            Preco = servico.Preco;
            Descricao = servico.Descricao;
            DuracaoEmMin = servico.DuracaoEmMin;
        }
    }
}
