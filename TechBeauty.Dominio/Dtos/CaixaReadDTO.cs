using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class CaixaReadDTO
    {
        public int Id { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinalCaixa { get; set; }
        public DateTime DataHoraCriacao { get;  set; }
        public DateTime DataHoraFechamento { get; set; }
        public decimal LucroDiario { get;  set; }
        public decimal RetiradasDiarias { get;  set; }

        public static object Paginar(List<Caixa> caixas)
        {
            List<CaixaReadDTO> dto = new();
            foreach (var item in caixas)
            {
                CaixaReadDTO caixaRead = new();
               
                caixaRead.SaldoInicial = item.SaldoInicial;
                caixaRead.SaldoFinalCaixa = item.SaldoFinalCaixa;
                caixaRead.DataHoraCriacao = item.DataHoraCriacao;
                caixaRead.DataHoraFechamento = item.DataHoraFechamento;
                caixaRead.LucroDiario = item.LucroDiario;
                caixaRead.RetiradasDiarias = item.RetiradasDiarias;
                dto.Add(caixaRead);
            }
            return dto;
        }


    }
}
