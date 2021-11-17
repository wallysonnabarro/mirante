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
    public class ContratoTrabalhoRepositorio : RepositorioBase<ContratoTrabalho>
    {
        public void EncerrarContrato(int id, DateTime dataEncerramento)
        {
            var contrato = context.ContratoTrabalho.First(x => x.Id == id);
            if (contrato != null)
            {
                contrato.EncerrarContrato(dataEncerramento);
                base.Alterar(contrato);
            }
            else
            {
                throw new ArgumentException("Contrato não encontrado!");
            }
        }

        public ContratoTrabalhoReadDTO SelecionarJoin(int getContratoId)
        {
            if (context.ContratoTrabalho.Any(ct => ct.Id == getContratoId))
            {
                var innerJoin = (from ct in context.ContratoTrabalho
                                 join r in context.RegimeContratual on ct.Id equals r.Id
                                 where ct.Id == getContratoId
                                 orderby ct.Id
                                 select new { ct, r }).FirstOrDefault();

                ContratoTrabalhoReadDTO readDTO = new();

                var cargosJoin = (from c in context.Cargo
                                  join cct in context.CargoContratoTrabalho on c.Id equals cct.CargosId
                                  where cct.ContratosTrabalhosId == innerJoin.ct.Id
                                  orderby c.Id
                                  select new { c });

                List<CargoReadDTO> cargos = new();
                foreach (var cargoJoin in cargosJoin)
                {
                    Cargo cargo = cargoJoin.c;
                    CargoReadDTO dto = new();
                    dto.Id = cargo.Id;
                    dto.Nome = cargo.Nome;
                    dto.Descricao = cargo.Descricao;
                    cargos.Add(dto);
                }

                ContratoTrabalho contrato = innerJoin.ct;
                RegimeContratual regime = innerJoin.r;

                readDTO.CnpjCTPS = contrato.CnpjCTPS;
                readDTO.DataDesligamento = contrato.DataDesligamento;
                readDTO.DataEntrada = contrato.DataEntrada;
                readDTO.Id = contrato.Id;
                readDTO.Salario = contrato.Salario;
                readDTO.RegimeRead = RegimeContratual.CoverteRead(regime);
                readDTO.ReadCargos = cargos;

                return readDTO;
            }
            else
            {
                throw new ArgumentException($"Código {getContratoId} inválido!", nameof(getContratoId));
            }
        }

        public List<ContratoTrabalhoReadDTO> PaginarJoin(int skip, int take)
        {
            take = take > 0 ? take : 25;
            skip = skip >= 1 ? skip *= take : skip;

            var innerJoin = (from ct in context.ContratoTrabalho
                             join r in context.RegimeContratual on ct.Id equals r.Id
                             orderby ct.Id
                             select new { ct, r }).Take(take).Skip(skip).ToList();

            List<ContratoTrabalhoReadDTO> contratos = new();
            foreach (var contratoJoin in innerJoin)
            {
                var cargosJoin = (from c in context.Cargo
                                  join cct in context.CargoContratoTrabalho on c.Id equals cct.CargosId
                                  where cct.ContratosTrabalhosId == contratoJoin.ct.Id
                                  orderby c.Id
                                  select new { c });

                List<CargoReadDTO> cargos = new();
                foreach (var cargoJoin in cargosJoin)
                {
                    Cargo cargo = cargoJoin.c;
                    CargoReadDTO dto = new();
                    dto.Id = cargo.Id;
                    dto.Nome = cargo.Nome;
                    dto.Descricao = cargo.Descricao;
                    cargos.Add(dto);
                }

                ContratoTrabalho contrato = contratoJoin.ct;
                RegimeContratual regime = contratoJoin.r;

                ContratoTrabalhoReadDTO readDTO = new();
                readDTO.CnpjCTPS = contrato.CnpjCTPS;
                readDTO.DataDesligamento = contrato.DataDesligamento;
                readDTO.DataEntrada = contrato.DataEntrada;
                readDTO.Id = contrato.Id;
                readDTO.Salario = contrato.Salario;
                readDTO.RegimeRead = RegimeContratual.CoverteRead(regime);
                readDTO.ReadCargos = cargos;
                contratos.Add(readDTO);
            }
            return contratos;
        }
    }
}
