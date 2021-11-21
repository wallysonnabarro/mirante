using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class AgendamentoReadDTO
    {
        public int Id { get;  set; }
        public string PessoaAtendida { get; set; }
        public DateTime DataHoraCriacao { get;  set;}
        public DateTime DataHoraInicio { get;  set; }
        public DateTime DataHoraTermino { get;  set; }

        public static object Paginar(List<Agendamento> agendamentos)
        {
            List<AgendamentoReadDTO> dto = new();
            foreach (var item in agendamentos)
            {
                AgendamentoReadDTO agendamentoRead = new();
                agendamentoRead.Id = item.Id;
                agendamentoRead.PessoaAtendida = item.PessoaAtendida;
                agendamentoRead.DataHoraCriacao = item.DataHoraCriacao;
                agendamentoRead.DataHoraInicio = item.DataHoraInicio;
                agendamentoRead.DataHoraTermino = item.DataHoraTermino;
                dto.Add(agendamentoRead);
            }
            return dto;
        }

        public static AgendamentoReadDTO Selecionar(Agendamento agendamento)
        {
            AgendamentoReadDTO agendamentoRead = new();
            agendamentoRead.Id = agendamento.Id;
            agendamentoRead.PessoaAtendida = agendamento.PessoaAtendida;
            agendamentoRead.DataHoraCriacao = agendamento.DataHoraCriacao;
            agendamentoRead.DataHoraInicio = agendamento.DataHoraInicio;
            agendamentoRead.DataHoraTermino = agendamento.DataHoraTermino;
            return agendamentoRead;
        }
    }
}
