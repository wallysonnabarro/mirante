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
        public override void Incluir(TipoContato entity)
        {
            if (ValidarValor(entity))
            {
                base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException();
            }
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
            var existe = context.TipoContato.Where(tc => tc.Valor == contato.Valor).FirstOrDefault();
            if (existe == null)
            {
                return true;
            }
            return false;
        }
    }
}
