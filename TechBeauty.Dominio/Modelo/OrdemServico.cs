using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico : IEntity
    {
        public int Id { get; private set; }
        public int ClienteId { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaoTotal { get; private set; }
        public StatusOS Status { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public List<Agendamento> Agendamento { get; private set; } //navegação
        public List<Pagamento> Pagamentos { get; private set; }//navegação
        public Cliente Cliente { get; private set; }//navegação

        public static OrdemServico Criar(OrdemServicoDTO osDTO)
        {
            OrdemServico ordemServico = new();
            ordemServico.ClienteId = osDTO.ClienteID;
            ordemServico.Status = StatusOS.Pendente;
            ordemServico.DataCriacao = DateTime.Now;
            return ordemServico;
        }
        public void Alterar(OrdemServico ordemServico)
        {
            PrecoTotal = ordemServico.PrecoTotal;
            DuracaoTotal = ordemServico.DuracaoTotal;
            Cliente = ordemServico.Cliente;
            Status = ordemServico.Status;
        }

        public void AlterarPrecoTotalDuracao(Servico servico)
        {
            PrecoTotal += servico.Preco;
            DuracaoTotal += servico.DuracaoEmMin;
        }

        public static OrdemServico Alterar(OrdemServicoDTO os, int id)
        {
            throw new NotImplementedException();
        }

        public void AlterarStatus(int id)
        {
            Status = (StatusOS)id;
        }

        public void OrdemServicoID(int id)
        {
            Id = id;
            
        }
    }
}
