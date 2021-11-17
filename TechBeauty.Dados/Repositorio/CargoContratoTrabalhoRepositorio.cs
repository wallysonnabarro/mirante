using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoContratoTrabalhoRepositorio : RepositorioBase<CargoContratoTrabalho>
    {
        public void IncluirMuitos(List<int> cargosId, int contratoId)
        {
            foreach (var item in cargosId)
            {
                CargoContratoTrabalho cargoContratoTrabalho = new();
                cargoContratoTrabalho.CargosId = item;
                cargoContratoTrabalho.ContratosTrabalhosId = contratoId;
                context.CargoContratoTrabalho.Add(cargoContratoTrabalho);
                context.SaveChanges();
            }
        }

        public void AlterarTudo(int id, List<int> cargosId)
        {
            var cct = context.CargoContratoTrabalho.Where(x => x.ContratosTrabalhosId == id).ToList();
            foreach (var item in cct)
            {
                context.CargoContratoTrabalho.Remove(item);
            }

            foreach (var item in cargosId)
            {
                base.Incluir(CargoContratoTrabalho.Incluir(id, item));
            }
        }
    }
}
