using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class CargoContratoTrabalho
    {
        public int ID { get; set; }
        public int CargoID { get; set; }
        public Cargo Cargo { get; set; }
        public int ContratoTrabalhoID { get; set; }
        public ContratoTrabalho ContratoTrabalho { get; set; }
    } 

    
}
