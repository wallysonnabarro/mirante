using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Escala : IEntity
    {
        public int Id { get; private set; }
        public DateTime DataHoraEntrada { get; private set; }
        public DateTime DataHoraSaida { get; private set; }
        public int ColaboradorId { get; private set; }
        public Colaborador Colaborador { get; private set; }

        public static Escala Criar(EscalaDTO dto)
        {
            Escala escala = new();
            escala.DataHoraEntrada = dto.DataHoraEntrada;
            escala.DataHoraSaida = dto.DataHoraSaida;
            escala.ColaboradorId = dto.ColaboradorID;
            return escala;
        }

        public static Escala ModificarEscala(EscalaDTO dto, int id)
        {
            Escala escala = new();
            escala.Id = id;
            escala.DataHoraEntrada = dto.DataHoraEntrada;
            escala.DataHoraSaida = dto.DataHoraSaida;
            escala.ColaboradorId = dto.ColaboradorID;
            return escala;
        }



        public void HoraSaida(DateTime dataHoraSaida)
        {
            DataHoraSaida = dataHoraSaida;
        }

    }

}
