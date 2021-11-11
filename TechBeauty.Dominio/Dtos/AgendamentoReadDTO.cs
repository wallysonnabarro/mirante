﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class AgendamentoReadDTO
    {
        public int Id { get; private set; }
        public string PessoaAtendida { get; private set; }
        public DateTime DataHoraCriacao { get; private set;}
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraTermino { get; private set; }

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

    }
}