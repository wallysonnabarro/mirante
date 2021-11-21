using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Interfaces;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento : IEntity
    {
        public int Id { get; private set; }
        public int ServicoId { get; private set; }
        public int ColaboradorId { get; private set; }
        public int OrdemServicoId { get; private set; }
        public string PessoaAtendida { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraTermino { get; private set; }
        public StatusAgendamento Status { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public List<LogAgendamento> LogAgendamentos { get; private set; }
        public Comissao Comissao { get; private set; }//navegação

        public static Agendamento Criar(AgendamentoDTO dto)
        {
            Agendamento agendamento = new();
            agendamento.ServicoId = dto.ServicoID;
            agendamento.ColaboradorId = dto.ColaboradorID;
            agendamento.PessoaAtendida = dto.PessoaAtendida;
            agendamento.OrdemServicoId = dto.OrdemSID;
            agendamento.DataHoraCriacao = DateTime.Now;
            agendamento.DataHoraInicio = dto.DataHoraInicio;
            agendamento.DataHoraTermino = dto.DataHoraTermino;
            agendamento.Status = StatusAgendamento.Agendado;
            return agendamento;
        }

        public static Agendamento RemarcarAgendamento(AgendamentoDTO dto, int id)
        {
            Agendamento ag = new();
            ag.Id = id;
            ag.ColaboradorId = dto.ColaboradorID;
            ag.DataHoraCriacao = dto.DataHoraInicio;
            ag.DataHoraTermino = dto.DataHoraTermino;
            ag.ServicoId = dto.ServicoID;
            return ag;
        }

        public void AlterarStatusAgendamento(StatusAgendamento status)
        {
            Status = status;
        }
    }
}
