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
        protected readonly Context context;

        public LogAgendamentoRepositorio()
        {
            context = new();
        }

        public void CriarLog(LogAgendamento logAgendamento)
        {
            context.LogAgendamento.Add(logAgendamento);
            context.SaveChanges();
        }

        public List<LogAgendamento> agendamentos()
        {
            return context.LogAgendamento.ToList();
        }

        public LogAgendamento SelecionarLog(int id)
        {
            return context.LogAgendamento.FirstOrDefault(x => x.Id == id);
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
