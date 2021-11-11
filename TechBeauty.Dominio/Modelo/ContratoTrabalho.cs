﻿using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho : IEntity
    {
        public int Id { get; private set; }
        public Colaborador Colaborador { get; set; }
        public RegimeContratual RegimeContratual { get; private set; } //Navegação relação (1,1) é necessário popular
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }
        public List<Cargo> Cargos { get; private set; }
        public string CnpjCTPS { get; private set; }

        public static ContratoTrabalho Contratar(RegimeContratual regimeContratual, DateTime dataEntrada, 
            List<Cargo> cargos, string cnpjCTPS, Colaborador colaborador)
        {
            ContratoTrabalho contratoTrabalho = new();
            contratoTrabalho.Colaborador = colaborador;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = dataEntrada;
            contratoTrabalho.Cargos= cargos;
            contratoTrabalho.CnpjCTPS = cnpjCTPS;
            return contratoTrabalho;
            
        }
        public void ModificarContrato(ContratoTrabalho contratoTrabalho)
        {
            
            RegimeContratual = contratoTrabalho.RegimeContratual;
            DataEntrada = contratoTrabalho.DataEntrada;
            DataDesligamento = contratoTrabalho.DataDesligamento;
            Cargos = contratoTrabalho.Cargos;
            Colaborador = contratoTrabalho.Colaborador;
            CnpjCTPS = contratoTrabalho.CnpjCTPS;
        }
        public void EncerrarContrato(DateTime dataDesligamento)
        {
            DataDesligamento = dataDesligamento;
        }

        public static ContratoTrabalho Atualizar(ContratoTrabalhoDTO dto, RegimeContratual regime, List<Cargo> cargos, Colaborador colaborador, int id)
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
    }
}
