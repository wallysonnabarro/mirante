using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ContatoRepositorio
    {
        private readonly Context context;

        public ContatoRepositorio()
        {
            context = new();
        }

        public void Incluir(Contato contato)
        {
            context.Contato.Add(contato);
            context.SaveChanges();
        }

        public void Alterar(int id, Contato contato)
        {
            context.Contato.FirstOrDefault(x => x.Id == id).AlterarContato(contato);
            context.SaveChanges();
        }

        public Contato PegarContato(int id)
        {
            return context.Contato.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Contato.Remove(context.Contato.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<Contato> Tabela()
        {
            return context.Contato.ToList();
        }
    }
}
