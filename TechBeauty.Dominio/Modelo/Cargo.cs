using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Cargo : IEntity
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public ICollection<CargoContratoTrabalho> CargoContratosTrabalho { get; private set; }
        public ICollection<Servico> Servicos { get; private set; }

        public static Cargo CriarCargo(CargoDto dto)
        {
            Cargo cargo = new();
            cargo.Nome = dto.Nome;
            cargo.Descricao = dto.Descricao;
            return cargo;
        }

        public static Cargo AlterarCargo(CargoDto dto, int id)
        {
            Cargo cargo = CriarCargo(dto);
            cargo.Id = id;
            return cargo;
        }
    }
}
