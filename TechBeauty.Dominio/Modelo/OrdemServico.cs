using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico : IEntity
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaoTotal { get; private set; }
        public List<Agendamento> Agendamento { get; private set; } //navegação
        public List<Pagamento> Pagamentos { get; set; }//navegação

        public Cliente Cliente { get; private set; }
        public StatusOS Status { get; private set; }

        public static OrdemServico Criar(OrdemServicoDTO osDTO, Cliente cliente)
        {
            OrdemServico ordemServico = new();
            
            ordemServico.PrecoTotal = osDTO.PrecoTotal;
            ordemServico.DuracaoTotal = osDTO.DuracaoTotal;
            ordemServico.Cliente = cliente;
            ordemServico.Status = StatusOS.Pendente;
            return ordemServico;
        }
        public void Alterar(OrdemServico ordemServico)
        {
            PrecoTotal = ordemServico.PrecoTotal;
            DuracaoTotal = ordemServico.DuracaoTotal;
            Cliente = ordemServico.Cliente;
            Status = ordemServico.Status;
        }

        public void AlterarPrecoTotal(decimal precoTotal)
        {
            PrecoTotal += precoTotal;
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
