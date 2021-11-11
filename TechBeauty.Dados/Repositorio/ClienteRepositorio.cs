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
            throw new ArgumentException("");
        }
    }
}
