using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class EspacoClienteRepositorio
    {
        public List<EspacoCliente> TabelaEspacoCliente { get; private set; } = new();

        public EspacoClienteRepositorio()
        {

        }
        public void Incluir(EspacoCliente espacoCliente)
        {
            TabelaEspacoCliente.Add(espacoCliente);
        }
        public void ValidacaoBeneficio(int id, Beneficio beneficio)
        {
            TabelaEspacoCliente.FirstOrDefault(x => x.Id == id).ValidarBeneficio(beneficio);
        }
        public EspacoCliente SelecionarPorId(int id)
        {
            return TabelaEspacoCliente.FirstOrDefault(x => x.Id == id);
        }
        public void Remover(int id)
        {
            TabelaEspacoCliente.Remove(SelecionarPorId(id));
        }
    }
}
