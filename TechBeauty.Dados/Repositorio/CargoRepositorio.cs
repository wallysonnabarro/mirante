using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio : RepositorioBase<Cargo>
    {
        public override int Incluir(Cargo entity)
        {
            if (!context.Cargo.Any(x => x.Nome == entity.Nome))
            {
                return base.Incluir(entity);
            }
            else
            {
                throw new ArgumentException($"Cargo com o nome= {entity.Nome}, já existente!", nameof(entity.Nome));
            }
        }

        public override void Alterar(Cargo entity)
        {
            if (context.Cargo.Any(c => c.Id == entity.Id))
            {
                base.Alterar(entity);
            }
            else
            {
                throw new ArgumentException($"O cargo {entity.Nome}, com o id {entity.Id} não encontrado.", nameof(entity.Id));
            }
        }

        public List<Cargo> SelecionarCargos(List<int> cargosId)
        {
            List<Cargo> cargos = new();
            foreach (var item in cargosId)
            {
                cargos.Add(context.Cargo.FirstOrDefault(c => c.Id == item));
            }
            return cargos;
        }
    }
}
