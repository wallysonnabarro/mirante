using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EscalaRepositorio
    {
        private readonly Context context;

        public EscalaRepositorio()
        {
            context = new();
        }

        public void Incluir(Escala escala)
        {
            context.Escala.Add(escala);
            context.SaveChanges();
        }

        public void Alterar(Escala escala)
        {
            context.Escala.Update(escala);
            context.SaveChanges();
        }

        public Escala PegarEscala(int id)
        {
            return context.Escala.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Escala.Remove(PegarEscala(id));
            context.SaveChanges();
        }

        public List<Escala> Tabela()
        {
            return context.Escala.ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
