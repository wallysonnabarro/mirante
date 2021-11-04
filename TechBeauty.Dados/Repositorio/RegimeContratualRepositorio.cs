using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class RegimeContratualRepositorio
    {
        private readonly Context context;

        public RegimeContratualRepositorio()
        {
            context = new();
        }

        public void Incluir(RegimeContratual regimeContratual)
        {
            context.RegimeContratual.Add(regimeContratual);
            context.SaveChanges();
        }

        public void Alterar(int id, RegimeContratual regimeContratual)
        {
            context.RegimeContratual.FirstOrDefault(x => x.Id == id).AlterarRegimeContratual(regimeContratual.Valor);
            context.SaveChanges();
        }

        public RegimeContratual PegarRegimeContratual(int id)
        {
            return context.RegimeContratual.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.RegimeContratual.Remove(context.RegimeContratual.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<RegimeContratual> Tabela()
        {
            return context.RegimeContratual.ToList();
        }
    }
}
