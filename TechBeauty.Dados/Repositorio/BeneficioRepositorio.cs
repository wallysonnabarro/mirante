using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;

namespace TechBeauty.Dados.Repositorio
{
    public class BeneficioRepositorio
    {
        private readonly Context _context;

        public BeneficioRepositorio()
        {
            _context = new();
        }

        public void IncluirBeneficio(Beneficio beneficio)
        {
            _context.Beneficio.Add(beneficio);
            _context.SaveChanges();
        }

        public void AlterarBeneficio(Beneficio beneficio)
        {
            _context.Beneficio.Update(beneficio);
            _context.SaveChanges();
        }

        public void ExcluirBeneficio(int id)
        {
            _context.Beneficio.Remove(SelecionarBeneficio(id));
            _context.SaveChanges();
        }

        public Beneficio SelecionarBeneficio(int id)
        {
            return _context.Beneficio.FirstOrDefault(x => x.Id == id);
        }

        public List<Beneficio> Tabela()
        {
            return _context.Beneficio.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
