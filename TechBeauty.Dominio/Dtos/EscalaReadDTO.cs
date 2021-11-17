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
            foreach (var item in escalas)
            {
                foreach (var col in colaboradors)
                {
                    EscalaReadDTO dTO = new();
                    dTO.DataHoraEntrada = item.DataHoraEntrada;
                    dTO.DataHoraSaida = item.DataHoraSaida;
                    dTO.Id = item.Id;
                    dTO.ColaboradorId = item.ColaboradorId;
                    dTO.Colaborador = col.Nome;
                    escalaReads.Add(dTO);
                }
            }
            return escalaReads;
        }
    }
}
