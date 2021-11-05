using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Dados.Repositorio
{
    class GestaoRepositorio
    {
        private readonly Context context;

        public GestaoRepositorio()
        {
            context = new();
        }

        public void Incluir(Gestao gestao)
        {
            context.Add(gestao);
            context.SaveChanges();
        }
        public void Atualizar(Gestao gestao)
        {
            context.Gestao.Update(gestao);
            context.SaveChanges();
        }

        public Gestao SelecionarPorId(int id)
        {
            return context.Gestao.FirstOrDefault(x => x.Id == id);

        }
        public void Remover(int id)
        {
            context.Gestao.Remove(SelecionarPorId(id));
        }

        public List<Gestao> Tabela()
        {
            return context.Gestao.ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
