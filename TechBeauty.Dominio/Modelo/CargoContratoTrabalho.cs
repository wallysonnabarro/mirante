using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class CargoContratoTrabalho : IEntity
    {
        public int Id { get; private set; }
        public int CargosId { get; set; }
        public int ContratosTrabalhosId { get; set; }
        //Navegações
        public Cargo Cargo { get; set; }
        public ContratoTrabalho ContratoTrabalho { get; set; }

        public static CargoContratoTrabalho Incluir(int id, int item)
        {
            CargoContratoTrabalho cargoContratoTrabalho = new();
            cargoContratoTrabalho.CargosId = item;
            cargoContratoTrabalho.ContratosTrabalhosId = id;
            return cargoContratoTrabalho;
        }
    }
}
