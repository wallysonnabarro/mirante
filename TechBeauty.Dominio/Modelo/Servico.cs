using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Servico : IEntity
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public int DuracaoEmMin { get; private set; }
        public List<Agendamento> Agendamentos { get; set; }
        public List<Colaborador> Colaboradores { get; set; }

        public static Servico Criar(ServicoDTO dto)
        {
            Servico servico = new();
            servico.Nome = dto.Nome;
            servico.Preco = dto.Preco;
            servico.Descricao = dto.Descricao;
            servico.DuracaoEmMin = dto.DuracaoEmMin;
            return servico;
        }
        public void ModificarServico(Servico servico)
        {
            Nome = servico.Nome;
            Preco = servico.Preco;
            Descricao = servico.Descricao;
            DuracaoEmMin = servico.DuracaoEmMin;
        }

        public static Servico Alterar(ServicoReadDTO dto, int id)
        {
            Servico servico = new();
            servico.Id = id;
            servico.Nome = dto.Nome;
            servico.Descricao = dto.Descricao;
            servico.Preco = dto.Preco;
            servico.DuracaoEmMin = dto.DuracaoEmMin;
            return servico;
        }
    }
}
