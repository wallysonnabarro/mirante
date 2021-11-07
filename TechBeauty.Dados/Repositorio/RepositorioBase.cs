using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dados.Repositorio
{
    public class RepositorioBase<T> where T : class, IEntity
    {
        protected readonly Context context;

        public RepositorioBase()
        {
            context = new();
        }

        public virtual void Incluir(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Alterar (T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public T Selecionar(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> Paginar(int skip)
        {
            int take = 25;

            if (skip >= 1)
            {
                skip *= take;
            }

            return context.Set<T>().OrderBy(c => c.Id).Skip(skip).Take(take).ToList();
        }


        public void Excluir(int id)
        {
            context.Set<T>().Remove(Selecionar(id));
        }

        public List<T> Tabela (T entity)
        {
            return context.Set<T>().Where(x => x.Id == entity.Id).ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
