using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class OrdemServicoRepositorio
    {
        private readonly Context context;

        public OrdemServicoRepositorio()
        {
            context = new();
        }

        public void Incluir(OrdemServico ordemServico)
        {
            context.OrdemServico.Add(ordemServico);
            context.SaveChanges();
        }

        public void Alterar(OrdemServico ordemServico)
        {
            context.OrdemServico.Update(ordemServico);
            context.SaveChanges();
        }

        public OrdemServico PegarOrdemServico(int id)
        {
            return context.OrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.OrdemServico.Remove(PegarOrdemServico(id));
            context.SaveChanges();
        }

        public List<OrdemServico> Tabela()
        {
            return context.OrdemServico.ToList();
        }

        public void AlterarPrecototal(int id, decimal valor)
        {
            context.OrdemServico.FirstOrDefault(x => x.Id == id).AlterarPrecoTotal(valor);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
