using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho : IEntity
    {
        public int Id { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }
        public string CnpjCTPS { get; private set; }
        public decimal PorcentagemComissao { get; private set; }
        public decimal Salario { get; private set; }
        public RegimeContratual RegimeContratual { get; private set; } //Navegação relação (1,1) é necessário popular
        public List<Cargo> Cargos { get; private set; }//Tabela relacional

        public static ContratoTrabalho Contratar(RegimeContratual regimeContratual, List<Cargo> cargos,
            Colaborador colaborador, ContratoTrabalhoDTO dto)
        {
            ContratoTrabalho contratoTrabalho = new();
            contratoTrabalho.Colaborador = colaborador;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = dto.DataEntrada;
            contratoTrabalho.Cargos = cargos;
            contratoTrabalho.CnpjCTPS = dto.CnpjCtps;
            contratoTrabalho.PorcentagemComissao = dto.ProcentagemComissao;
            contratoTrabalho.Salario = dto.Salario;
            return contratoTrabalho;

        }
        public void EncerrarContrato(DateTime dataDesligamento)
        {
            DataDesligamento = dataDesligamento;
        }

        public static ContratoTrabalho Atualizar(ContratoTrabalhoDTO dto, RegimeContratual regime,
            List<Cargo> cargos, Colaborador colaborador, int id)
        {
            ContratoTrabalho contrato = new();
            contrato.Id = id;
            contrato.RegimeContratual = regime;
            contrato.Cargos = cargos;
            contrato.Colaborador = colaborador;
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
    }
}
