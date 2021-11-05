using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Beneficio
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<EspacoCliente> EspacosClientes { get; set; }//Navegação, não será populada

        public static Beneficio GerarBeneficio(string nome, string descricao)
        {
            Beneficio beneficio = new();
            beneficio.Nome = nome;
            beneficio.Descricao = descricao;
            return beneficio;
        }
        public void AlterarBeneficio(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
