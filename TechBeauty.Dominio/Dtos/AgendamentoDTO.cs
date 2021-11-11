using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class AgendamentoDTO
    {
        [StringLength(30, ErrorMessage = "Quantidade máximo de caracteres = 30")]
        [Required(ErrorMessage = "O campo 'PessoaAtendida' do Agendamento é obrigatório!")]
        public string PessoaAtendida { get; set; }

        [Required(ErrorMessage = "O campo 'DataHoraInicio' do Agendamento é obrigatório!")]
        public DateTime DataHoraInicio { get; set; }

        [Required(ErrorMessage = "O campo 'DataHoraTermino' do Agendamento é obrigatório!")]
        public DateTime DataHoraTermino { get; set; }
        public int OrdemSID { get; set; }
        public int StatusAgendamento { get; set; }
        public int ColaboradorID { get; set; }
        public int ServicoID { get; set; }

        public static AgendamentoDTO CriarAgendamento(AgendamentoDTO agendamento)
        {
            AgendamentoDTO dto = new();
            dto.PessoaAtendida = agendamento.PessoaAtendida;
            dto.DataHoraTermino = agendamento.DataHoraTermino;
            dto.DataHoraInicio = agendamento.DataHoraInicio;
            dto.OrdemSID = agendamento.OrdemSID;
            dto.StatusAgendamento = agendamento.StatusAgendamento;
            dto.ColaboradorID = agendamento.ColaboradorID;
            dto.ServicoID = agendamento.ServicoID;
            return dto;
        }
    }
}
