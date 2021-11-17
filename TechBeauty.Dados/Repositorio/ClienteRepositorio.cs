using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<Cliente>
    {
        public override int Incluir(Cliente entity)
        {
            if (!context.Cliente.Any(c => c.CPF == entity.CPF))
            {
                return base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException("Cliente já cadastrado!", nameof(entity.CPF));
            }
        }

        public void ExcluirCascata(int id)
        {
            if (context.Cliente.Any(x => x.Id == id))
            {
                var cliente = context.Cliente.FirstOrDefault(c => c.Id == id);
                var contato = context.Contato.Where(c => c.PessoaId == id).ToList();

                context.Remove(cliente);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Cliente não encontrado!", nameof(id));
            }
        }

        public Cliente SelecionarCliente(int id)
        {
            if (context.Cliente.Any(x => x.Id == id))
            {
                return context.Cliente.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                throw new ArgumentException("Cliente não encontrado!", nameof(id));
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            if (context.Cliente.Any(x => x.Id == cliente.Id))
            {
                context.Cliente.Update(cliente);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Cliente não encontrado!");
            }
        }
    }
}
