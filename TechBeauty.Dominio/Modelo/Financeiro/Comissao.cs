using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    public class Comissao : IEntity
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public int AgendamentoId { get; private set; }
        public Agendamento Agendamento { get; private set; }//navegação

        public static Comissao GerarComissao(decimal preco, decimal porcentagem, int agendamentoId)
        {
            Comissao comissao = new();
            comissao.Valor = preco * porcentagem;
            comissao.AgendamentoId = agendamentoId;
            return comissao;
        }

        public static decimal TotalComissoes(List<Comissao> comissaos)
        {
            decimal valorTotal = 0;
            foreach (var comissao in comissaos)
            {
                valorTotal += comissao.Valor;
            }
            return valorTotal;
        }
    }
}
