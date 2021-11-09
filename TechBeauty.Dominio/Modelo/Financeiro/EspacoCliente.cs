

using TechBeauty.Dominio.Modelo.Financeiro;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class EspacoCliente : IEntity
    {
        public int Id { get; private set; }
        public Beneficio Beneficio { get; private set; }//será populado
        public Cliente Cliente { get; private set; } //Referenciar
        public Gestao Gestao{ get; set; }

        public static EspacoCliente CriarBeneficio(Cliente cliente, Gestao gestao, Beneficio beneficio)
        {
            EspacoCliente espacoCliente = new();
            espacoCliente.Cliente = cliente;
            espacoCliente.Gestao = gestao;
            espacoCliente.Beneficio = beneficio;
            return espacoCliente;
        }

        public void ValidarBeneficio(Beneficio beneficio)
        {
            Beneficio = beneficio;
        }
    }
}
