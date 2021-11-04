using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio
    {
        private readonly Context context;

        public GeneroRepositorio()
        {
            context = new();
        }

        public void Incluir(Genero genero)
        {
            context.Genero.Add(genero);
            context.SaveChanges();
        }

        public void Alterar(Genero genero)
        {
            context.Genero.Update(genero);
            context.SaveChanges();
        }

        public Genero PegarGenero(int id)
        {
            return context.Genero.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Genero.Remove(PegarGenero(id));
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
