using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class EscalaReadDTO
    {
        public int Id { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public int ColaboradorId { get; set; }
        public string Colaborador { get; set; }

        public static List<EscalaReadDTO> Paginar(List<Escala> escala)
        {
            List<EscalaReadDTO> dtos = new();
            foreach (var item in escala)
            {
                EscalaReadDTO dto = new();
                dto.Id = item.Id;
                dto.DataHoraEntrada = item.DataHoraEntrada;
                dto.DataHoraSaida = item.DataHoraSaida;
                dtos.Add(dto);
            }
            return dtos;
        }

        public static List<EscalaReadDTO> Converter(List<Colaborador> colaboradors, List<Escala> escalas)
        {
            List<EscalaReadDTO> escalaReads = new();
            for (int i = 0; i < escalas.Count; i++)
            {
                Escala escala = escalas[i];
                EscalaReadDTO dTO = new();
                dTO.Id = escala.Id;
                dTO.DataHoraEntrada = escala.DataHoraEntrada;
                dTO.DataHoraSaida = escala.DataHoraSaida;
                dTO.ColaboradorId = escala.ColaboradorId;
                dTO.Colaborador = colaboradors[i].Nome;
                escalaReads.Add(dTO);
            }
            return escalaReads;
        }
    }
}
