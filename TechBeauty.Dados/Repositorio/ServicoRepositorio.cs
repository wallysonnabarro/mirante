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

        public ICollection<Servico> Serviços(ICollection<int> serviçosId)
        {
            ICollection<Servico> servicos = new HashSet<Servico>();
            foreach (var item in serviçosId)
            {
                Servico servico = context.Servico.FirstOrDefault(s => s.Id == item);
                servicos.Add(servico);
            }
            return servicos;
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
