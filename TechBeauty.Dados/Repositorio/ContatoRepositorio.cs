using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ContatoRepositorio : RepositorioBase<Contato>
    {
        public void IncluirContato(int id, ColaboradorDTO colaborador)
        {
            foreach (var item in colaborador.ContatosDtos)
            {
                if (true)
                {
                    context.Contato.Add(Contato.Criar(id, item));
                }
                else
                {
                    throw new ArgumentException("Tipo de contato não encontrado!", nameof(id));
                }
            }
        }

        public void IncluirContatoCliente(int id, ClienteDTO cliente)
        {
            foreach (var item in cliente.ContatosDtos)
            {
                base.Incluir(Contato.Criar(id, item));
            }
        }
    }
}
