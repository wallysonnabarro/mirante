using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho : IEntity
    {

        public int Id { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }
        public string CnpjCTPS { get; private set; }
        public decimal PorcentagemComissao { get; private set; }
        public decimal Salario { get; private set; }


        public int RegimeContratualId { get; private set; }
        public int ColaboradorId { get; private set; }
        public Colaborador Colaborador { get; private set; }//navegação
        public RegimeContratual RegimeContratual { get; private set; } //Navegação
        public virtual ICollection<CargoContratoTrabalho> CargoContratoTrabalho { get; private set; }//Navegação

        public static ContratoTrabalho Contratar(ContratoTrabalhoDTO dto)
        {
            ContratoTrabalho contratoTrabalho = new();
            contratoTrabalho.ColaboradorId = dto.ColaboradorId;
            contratoTrabalho.RegimeContratualId = dto.ColaboradorId;
            contratoTrabalho.DataEntrada = dto.DataEntrada;
            contratoTrabalho.CnpjCTPS = dto.CnpjCtps;
            contratoTrabalho.PorcentagemComissao = dto.ProcentagemComissao;
            contratoTrabalho.Salario = dto.Salario;
            return contratoTrabalho;
        }
        public void EncerrarContrato(DateTime dataDesligamento)
        {
            DataDesligamento = dataDesligamento;
        }

        public static ContratoTrabalho Atualizar(ContratoTrabalhoDTO dto, int id)
        {
            ContratoTrabalho contrato = new();
            contrato.Id = id;
            contrato.RegimeContratualId = dto.RegimeId;
            contrato.ColaboradorId = dto.ColaboradorId;
            contrato.CnpjCTPS = dto.CnpjCtps;
            contrato.DataEntrada = dto.DataEntrada;
            return contrato;
        }

        public void UpdatePorcentagemComissao(decimal porcentagem)
        {
            PorcentagemComissao = porcentagem;
        }

        public void AtualizarSalario(decimal salario)
        {
            Salario = salario;
        }

        public void RegistrarCargos()
        {

        }
    }
}
