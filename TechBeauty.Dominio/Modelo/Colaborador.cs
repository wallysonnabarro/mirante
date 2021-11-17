using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa, IEntity
    {
        public int GeneroId { get; private set; }
        public int EnderecoId { get; private set; }
        public Genero Genero { get; private set; }//navegação
        public Endereco Endereco { get; private set; }//navegação
        public ICollection<ContratoTrabalho> Contratos { get; private set; }// navegação
        public ICollection<Escala> Escala { get; private set; }//navegação
        public ICollection<Agendamento> Agendamentos { get; set; }// navegação

        public static Colaborador Criar(ColaboradorDTO colaboradorDto, int enderecoId)
        {
            Colaborador colaborador = new();
            colaborador.Nome = colaboradorDto.Nome;
            colaborador.CPF = colaboradorDto.CPF;
            colaborador.DataNascimento = colaboradorDto.DataNascimento;
            colaborador.EnderecoId = enderecoId;
            colaborador.GeneroId = colaboradorDto.GeneroId;
            return colaborador;
        }

        public static Colaborador Atualizar(ColaboradorAtualizarDto dto)
        {
            Colaborador colaborador = new();
            colaborador.Nome = dto.Nome;
            colaborador.CPF = dto.CPF;
            colaborador.DataNascimento = dto.DataNascimento;
            colaborador.GeneroId = dto.GeneroId;
            return colaborador;
        }
    }
}
