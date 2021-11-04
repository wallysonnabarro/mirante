using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    public class Comissao
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
