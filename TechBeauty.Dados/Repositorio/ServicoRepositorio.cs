using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ServicoRepositorio : RepositorioBase<Servico>
    {
        public override int Incluir(Servico entity)
        {
            if (!context.Servico.Any(s => s.Nome == entity.Nome))
            {
                return base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override void Alterar(Servico entity)
        {
            if (context.Servico.Any(s => s.Id == entity.Id))
            {
                base.Alterar(entity);
            }
            else
            {
                throw new ArgumentException($"Serviço {entity.Nome}, já existe!", nameof(entity.Nome));
            }
        }
    }
}
