using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa
    {
        public string CarteiraTrabalho { get; private set; }
        public List<Servico> Servicos { get; private set; }
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string NomeSocial { get; private set; }
        public Collection<ContratoTrabalho> Contratos { get; private set; }
        public Escala Escala { get; private set; }
        public List<Agendamento> Agendamentos { get; set; }

        public static Colaborador Criar(Colaborador colaboradorDto)
        {
            Colaborador colaborador = new();
            colaborador.CarteiraTrabalho = colaboradorDto.CarteiraTrabalho;
            colaborador.Servicos = colaboradorDto.Servicos;
            colaborador.Endereco = colaboradorDto.Endereco;
            colaborador.Genero = colaboradorDto.Genero;
            colaborador.NomeSocial = colaboradorDto.NomeSocial;
            colaborador.Escala = colaboradorDto.Escala;

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
