using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento : IEntity
    {
        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public string PessoaAtendida { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraTermino { get; private set; }
        public StatusAgendamento Status { get; private set; }
        public List<LogAgendamento> LogAgendamentos { get; set; }



        public static Agendamento Criar(AgendamentoDTO dto, Servico servico, Colaborador colaborador, OrdemServico os)
        {
            Agendamento agendamento = new();

            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendida = dto.PessoaAtendida;
            agendamento.OrdemServico = os;
            return agendamento;
        }
        
        public static Agendamento RemarcarAgendamento(AgendamentoDTO dto, Colaborador colaborador,
           OrdemServico os, int id) 
        {
            Agendamento ag = new();
            ag.Id = id;
            ag.Colaborador = colaborador;
            ag.OrdemServico = os;
            ag.DataHoraCriacao = dto.DataHoraInicio;
            ag.DataHoraTermino = dto.DataHoraTermino;
            return ag;
        }
        public void ExecucaoServico(DateTime dataHoraInicio)
        {
            DataHoraInicio = dataHoraInicio;
        }

      

        public void AlterarStatusAgendamento(StatusAgendamento status)
        {
            Status = status;
        }
        public void TerminoServico(DateTime dataHoraTermino)
        {
            DataHoraTermino = dataHoraTermino;
        }
    }

}
