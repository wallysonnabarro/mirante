using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly Context context;

        public ClienteRepositorio()
        {
            context = new();
        }

        public void Incluir(Cliente cliente)
        {
            context.Cliente.Add(cliente);
            context.SaveChanges();
        }

        public void Alterar(int id, Cliente cliente)
        {
            context.Cliente.FirstOrDefault(x => x.Id == id).AlterarCliente(cliente);
            context.SaveChanges();
        }

        public Cliente PegarCliente(int id)
        {
            return context.Cliente.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Cliente.Remove(context.Cliente.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<Cliente> Tabela()
        {
            return context.Cliente.ToList();
        }
    }
}
