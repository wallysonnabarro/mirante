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

        public int IncluirBeneficio(BeneficioDto beneficio)
        {
            Beneficio b = beneficio.Converter(beneficio);
            _context.Beneficio.Add(b);
            _context.SaveChanges();
            return b.Id;
        }

        public void AlterarBeneficio(int id, BeneficioDto beneficio)
        {
            _context.Beneficio.FirstOrDefault(x => x.Id == id).AlterarBeneficio(beneficio.Nome, beneficio.Descricao);
            _context.SaveChanges();
        }

        public void ExcluirBeneficio(int id)
        {
            _context.Beneficio.Remove(_context.Beneficio.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
        }

        public Beneficio SelecionarBeneficio(int id)
        {
            return _context.Beneficio.FirstOrDefault(x => x.Id == id);
        }

        public List<BeneficioReadDto> Tabela()
        {
            List<BeneficioReadDto> beneficiosDto = new();
            var beneficios = _context.Beneficio.ToList();
            foreach (var beneficio in beneficios)
            {
                beneficiosDto.Add(BeneficioReadDto.CriarBeneficio(beneficio));
            }
            return beneficiosDto;
        }
    }
}
