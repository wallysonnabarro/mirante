using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
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

        public static Agendamento Criar(Servico servico, Colaborador colaborador, string pessoaAtendida,
            DateTime dataHoraCriacao, OrdemServico os)
        {
            Agendamento agendamento = new Agendamento();
            
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendida = pessoaAtendida;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.OrdemServico = os;
            
           
            
            return agendamento;
        }
        public void RemarcarAgendamento(Servico servico, Colaborador colaborador, string pessoaAtendida,
            DateTime dataHoraInicio, OrdemServico os, DateTime dataHoraCriacao, DateTime dataHoraTermino)
        {
            Servico = servico;
            Colaborador = colaborador;
            PessoaAtendida = pessoaAtendida;
            DataHoraInicio = dataHoraInicio;
            OrdemServico = os;
            DataHoraCriacao = dataHoraCriacao;
            DataHoraTermino = dataHoraTermino;
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
