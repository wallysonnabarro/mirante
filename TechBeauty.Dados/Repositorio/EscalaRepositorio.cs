using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EscalaRepositorio : RepositorioBase<Escala>
    {
        public List<EscalaReadDTO> PaginarPorColaborador(int colaboradorId, int skip, int take)
        {
            if (context.Colaborador.Any(x => x.Id == colaboradorId))
            {
                take = take > 0 ? take : 25;
                skip = skip >= 1 ? skip *= take : skip;

                var innerJoin = (from c in context.Colaborador
                                 join s in context.Escala on c.Id equals s.ColaboradorId
                                 where s.ColaboradorId == colaboradorId && s.DataHoraEntrada >= DateTime.Now
                                 orderby c.Id
                                 select new { s, c }).Take(take).Skip(skip).ToList();

                List<Colaborador> colaboradors = new();
                List<Escala> escalas = new();

                foreach (var item in innerJoin)
                {
                    Colaborador colaborador = item.c;
                    Escala escala = item.s;
                    colaboradors.Add(colaborador);
                    escalas.Add(escala);
                }
                return EscalaReadDTO.Converter(colaboradors, escalas);
            }
            else
            {
                throw new ArgumentException("Colaborador não foi encontrado!");
            }
        }

        public List<EscalaReadDTO> PaginarPorDataAtual(int skip, int take)
        {
            take = take > 0 ? take : 25;
            skip = skip >= 1 ? skip *= take : skip;

            var innerJoin = (from c in context.Colaborador
                             join s in context.Escala on c.Id equals s.ColaboradorId
                             where s.DataHoraEntrada >= DateTime.Now
                             orderby c.Id
                             select new { s, c }).Take(take).Skip(skip).ToList();

            List<Colaborador> colaboradors = new();
            List<Escala> escalas = new();

            foreach (var item in innerJoin)
            {
                Colaborador colaborador = item.c;
                Escala escala = item.s;
                colaboradors.Add(colaborador);
                escalas.Add(escala);
            }
            return EscalaReadDTO.Converter(colaboradors, escalas);
        }
    }
}

