using System;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class LogAgendamento
    {
        public int Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public StatusAgendamento Status { get; private set; }
        public Agendamento Agendamento { get; set; }

        public static LogAgendamento Criar(DateTime dataCriacao, StatusAgendamento status, Agendamento agendamento) 
        {
            LogAgendamento agenda = new LogAgendamento();
            agenda.DataCriacao = dataCriacao;
            agenda.Status = status;
            agenda.Agendamento = agendamento;
            return agenda;
        }
        public void Alterar(DateTime dataCriacao, StatusAgendamento status, Agendamento agendamento)
        {
            Agendamento = agendamento;
            DataCriacao = dataCriacao;
            Status = status;
            
        }
    }
}
