using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EnderecoRepositorio : RepositorioBase<Endereco>
    {
        public int IncluirComRetorno(Endereco endereco)
        {
            var end = context.Endereco.FirstOrDefault(e => e.Cep == endereco.Cep);
            if (end == null)
            {
                context.Endereco.Add(endereco);
                context.SaveChanges();
                return endereco.Id;
            }
            else
            {
                return end.Id;
            }
        }

        public override void Alterar(Endereco entity)
        {
            if (context.Endereco.Any(e => e.Id == entity.Id))
            {
                base.Alterar(entity);
            }
            else
            {
                throw new ArgumentException("Endereço não encontrado!.");
            }
        }
    }
}
