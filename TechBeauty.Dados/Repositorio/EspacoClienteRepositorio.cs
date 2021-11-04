using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class EspacoClienteRepositorio
    {
        protected readonly Context context;

        public EspacoClienteRepositorio()
        {
            context = new();
        }

        public void Incluir(EspacoCliente espacoCliente)
        {
            context.Add(espacoCliente);
            context.SaveChanges();
        }
        public void ValidacaoBeneficio(int id, Beneficio beneficio)
        {
            context.EspacoCliente.FirstOrDefault(x => x.Id == id).ValidarBeneficio(beneficio);
        }

        public EspacoCliente SelecionarPorId(int id)
        {
            return context.EspacoCliente.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Remove(SelecionarPorId(id));
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
