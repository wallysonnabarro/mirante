using System.Collections.Generic;
using System.Collections.ObjectModel;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa, IEntity
    {
        public string CarteiraTrabalho { get; private set; }
        public List<Servico> Servicos { get; private set; }
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string NomeSocial { get; private set; }
        public Collection<ContratoTrabalho> Contratos { get; private set; }// navegação
        public List<Escala> Escala { get; private set; }
        public List<Agendamento> Agendamentos { get; set; }// navegação

        public static Colaborador Criar(ColaboradorDTO colaboradorDto, Endereco endereco)
        {
            Colaborador colaborador = new();
            colaborador.CarteiraTrabalho = colaboradorDto.CarteiraTrabalho;
            colaborador.Endereco = endereco;
            //colaborador.Servicos = colaboradorDto.Servicos;
            //colaborador.Endereco = colaboradorDto.Endereco;
            //colaborador.Genero = colaboradorDto.Genero;
            //colaborador.NomeSocial = colaboradorDto.NomeSocial;
            //colaborador.Escala = colaboradorDto.Escala;

            return colaborador;
        }
        public void ModificarColaborador(Colaborador colaborador)
        {
            CarteiraTrabalho = colaborador.CarteiraTrabalho;
            Servicos = colaborador.Servicos;
            Endereco = colaborador.Endereco;
            Genero = colaborador.Genero;
            NomeSocial = colaborador.NomeSocial;
            Contratos = colaborador.Contratos;
            Escala = colaborador.Escala;
        }
        
    }
}
