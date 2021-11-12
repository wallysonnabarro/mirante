using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class ServicoColaborador
    {
        public int ID { get; set; }
        public int ColaboradorID { get; set; }
        public Servico Servico { get; set; }
        public int ServicoID { get; set; }
        public ContratoTrabalho ContratoTrabalho { get; set; }
    }
}
