using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class TipoContatoRepositorio
    {
        private readonly Context context;

        public TipoContatoRepositorio()
        {
            context = new();
        }

        public void Incluir(TipoContato tipoContato)
        {
            context.TipoContato.Add(tipoContato);
            context.SaveChanges();
        }

        public void Atualizar(TipoContato tipoContato)
        {
            context.TipoContato.Update(tipoContato);
            context.SaveChanges();
        }

        public TipoContato PegarTipoContato(int id)
        {
            return context.TipoContato.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Remove(PegarTipoContato(id));
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
