using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class LogAgendamentoRepositorio
    {
        public List<LogAgendamento> TabelaLogAgendamento { get; private set; } = new List<LogAgendamento>();

        public LogAgendamentoRepositorio()
        {

        }
        public void CriarLog(LogAgendamento logAgendamento)
        {
            TabelaLogAgendamento.Add(logAgendamento);
        }
        public List<LogAgendamento> agendamentos()
        {
            return TabelaLogAgendamento;
        }
    }
}
