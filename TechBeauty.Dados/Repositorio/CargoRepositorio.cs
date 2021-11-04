using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Dtos;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio
    {
        private readonly Context _context;

        public CargoRepositorio()
        {
            _context = new();
        }
        
        public int Incluir(CargoDto cargoDto)
        {
            Cargo cargo = Cargo.criarCargo(cargoDto.Nome, cargoDto.Descricao, cargoDto.Salario);
            _context.Cargo.Add(cargo);
            _context.SaveChanges();
            return cargo.Id;
        }

        public void Atualizar(int id, CargoDto cargo)
        {
            _context.Cargo.FirstOrDefault(x=>x.Id == id).AlterarCargo(cargo.Nome, cargo.Descricao);
            _context.SaveChanges();
        }

        public CargoDto PegarCargo(int id)
        {
            if (_context.Cargo.FirstOrDefault(x => x.Id == id) != null)
            {
                return CargoDto.Criar(_context.Cargo.FirstOrDefault(x => x.Id == id));
            }
            return null;
        }

        public void Remover(int id)
        {
            _context.Cargo.Remove(_context.Cargo.FirstOrDefault(x=>x.Id == id));
            _context.SaveChanges();
        }

        public List<ReadCargoDto> Tabela()
        {
            return ReadCargoDto.Colecao(_context.Cargo.ToList());
        }
    }
}
