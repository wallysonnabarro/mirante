using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    public class Comissao : IEntity
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public Agendamento Agendamento { get; private set; }

        public static Comissao GerarComissao(Agendamento agendamento, decimal porcentagem)
        {
            Comissao comissao = new();
            comissao.Valor = agendamento.Servico.Preco * porcentagem;
            comissao.Agendamento = agendamento;
            return comissao;
        }
    }
}
