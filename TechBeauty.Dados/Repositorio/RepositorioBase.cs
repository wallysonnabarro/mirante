using System;
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

        public virtual int Incluir(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public virtual void Alterar(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public virtual T Selecionar(int id)
        {
            if (context.Set<T>().FirstOrDefault(x => x.Id == id) != null)
            {
                return context.Set<T>().FirstOrDefault(x => x.Id == id);
            }
            throw new ArgumentException($"Identificação {id} não encontrada!", nameof(id));
        }

        public List<T> Paginar(int skip, int take)
        {
            take = take > 0 ? take : 25;
            skip = skip >= 1 ? skip *= take : skip;

            return context.Set<T>().OrderBy(c => c.Id).Skip(skip).Take(take).ToList();
        }


        public void Excluir(int id)
        {
            if (context.Set<T>().FirstOrDefault(x => x.Id == id) != null)
            {
                context.Set<T>().Remove(context.Set<T>().FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Identificação não encontrada!", nameof(id));
            }
        }

        public List<T> Tabela(T entity)
        {
            return context.Set<T>().Where(x => x.Id == entity.Id).ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
