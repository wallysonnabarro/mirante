using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class AgendaIncioReadDTO
    {
        public int Id { get; set; }
        public string PessoaAtendida { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraTermino { get; set; }
        public string Servico { get; set; }
        public string Colaborador { get; set; }

        public static List<AgendaIncioReadDTO> Conversor(List<Agendamento> agendamentos)
        {
            List<AgendaIncioReadDTO> dtos = new();
            foreach (var item in agendamentos)
            {
                dtos.Add(AgendaIncioReadDTO.Criar(item));
            }
            return dtos;
        }

        private static AgendaIncioReadDTO Criar(Agendamento item)
        {
            AgendaIncioReadDTO dto = new();
            dto.Id = item.Id;
            dto.PessoaAtendida = item.PessoaAtendida;
            dto.DataHoraInicio = item.DataHoraInicio;
            dto.DataHoraTermino = item.DataHoraTermino;
            dto.Servico = item.Servico.Nome;
            dto.Colaborador = item.Colaborador.Nome;
            return dto;
        }


    }
}
