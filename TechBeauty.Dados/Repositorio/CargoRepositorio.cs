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

        public void Incluir(Cargo cargo)
        {
            _context.Cargo.Add(cargo);
            _context.SaveChanges();
        }

        public void Atualizar(Cargo cargo)
        {
            _context.Cargo.Update(cargo);
            _context.SaveChanges();
        }

        public Cargo PegarCargo(int id)
        {
            return _context.Cargo.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            _context.Cargo.Remove(_context.Cargo.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
        }

        public List<ReadCargoDto> Tabela()
        {
            return ReadCargoDto.Colecao(_context.Cargo.ToList());
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
