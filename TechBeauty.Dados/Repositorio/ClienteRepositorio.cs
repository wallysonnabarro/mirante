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
        public override void Incluir(Cliente entity)
        {
            if (!context.Cliente.All(c => c.CPF.Equals(entity.CPF)))
            {
                base.Incluir(entity);
            }
        }
    }
}
