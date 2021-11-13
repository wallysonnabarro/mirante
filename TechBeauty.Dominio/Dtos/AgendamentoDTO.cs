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
        [Required(ErrorMessage = "O campo 'Pessoa Atendida' do Agendamento é obrigatório!")]
        public string PessoaAtendida { get; set; }
        [Required(ErrorMessage = "O campo 'Data Hora de Inicio' do Agendamento é obrigatório!")]
        public DateTime DataHoraInicio { get; set; }
        [Required(ErrorMessage = "O campo 'Data Hora de Termino' do Agendamento é obrigatório!")]
        public DateTime DataHoraTermino { get; set; }
        public int OrdemSID { get; set; }
        public int ColaboradorID { get; set; }
        public int ServicoID { get; set; }

    }
}
