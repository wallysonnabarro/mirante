using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class EscalaDTO
    {
        [Required(ErrorMessage = "O campo 'DataHoraEntrada' da escala é obrigatório!")]
        public DateTime DataHoraEntrada { get; set; }
        [Required(ErrorMessage = "O campo 'DataHoraSaida' da escala é obrigatório!")]
        public DateTime DataHoraSaida { get; set; }
        public int ColaboradorID { get; set; }
    }
}
