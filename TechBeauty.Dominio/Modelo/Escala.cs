using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Escala
    {
        public int Id { get; private set; }
        public DateTime DataHoraEntrada { get; private set; }
        public DateTime DataHoraSaida { get; private set; }
        public List<Colaborador> Colaboradores { get; private set; }

        public static Escala Criar(DateTime dataHoraEntrada, DateTime dataHoraSaida, List<Colaborador> colaboradores)
        {
            Escala escala = new();
            
            escala.DataHoraEntrada = dataHoraEntrada;
            escala.DataHoraSaida = dataHoraSaida;
            escala.Colaboradores = colaboradores;
            return escala;
        }

        public void ModificarEscala(Escala escala)
        {
            DataHoraEntrada = escala.DataHoraEntrada;
            DataHoraSaida = escala.DataHoraSaida;
            Colaboradores = escala.Colaboradores;
        }
        public void HoraSaida(DateTime dataHoraSaida)
        {
            DataHoraSaida = dataHoraSaida;
        }
    }
    
}
