using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico : IEntity
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaoTotal { get; private set; }
        public List<Agendamento> Agendamento { get; private set; } //navegação
        public List<Pagamento> Pagamentos { get; set; }//navegação
        public Cliente Cliente { get; private set; }
        public StatusOS Status { get; private set; }

        public static OrdemServico Criar(int id, decimal precoTotal, int duracaoTotal, Cliente cliente)
        {
            OrdemServico ordemServico = new();
            ordemServico.Id = id;
            ordemServico.PrecoTotal = precoTotal;
            ordemServico.DuracaoTotal = duracaoTotal;
            ordemServico.Cliente = cliente;
            ordemServico.Status = StatusOS.Pendente;
            return ordemServico;
        }
        public void Alterar(OrdemServico ordemServico)
        {
            PrecoTotal = ordemServico.PrecoTotal;
            DuracaoTotal = ordemServico.DuracaoTotal;
            Cliente = ordemServico.Cliente;
            Status = ordemServico.Status;
        }

        public void AlterarPrecoTotal(decimal precoTotal)
        {
            PrecoTotal += precoTotal;
        }
    }
}
