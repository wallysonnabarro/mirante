using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class TipoContatoRepositorio : RepositorioBase<TipoContato>
    {
        public override int Incluir(TipoContato entity)
        {
            if (ValidarValor(entity))
            {
                return base.Incluir(entity);
            }
            throw new ArgumentException();
        }

        public override void Alterar(TipoContato entity)
        {
            if (ValidarValor(entity))
            {
                base.Alterar(entity);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        protected bool ValidarValor(TipoContato contato)
        {
            if (context.TipoContato.Any(tc => tc.Valor == contato.Valor))
            {
                return true;
            }
            return false;
        }
    }
}
