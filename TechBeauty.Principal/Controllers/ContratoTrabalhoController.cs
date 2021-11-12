using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoTrabalhoController : ControllerBase
    {
        // GET: api/<ContratoTrabalhoController>/colecao
        [HttpGet("paginarContrato/{skip}/{take}")]
        public IActionResult Get(int skip = 0, int take = 25)
        {
            return Ok(new ContratoTrabalhoRepositorio().Paginar(skip, take));
        }

        // GET api/<ContratoTrabalhoController>/5
        [HttpGet("{getContratoId}")]
        public IActionResult Get(int getContratoId)
        {
            try
            {
                return Ok(new ContratoTrabalhoRepositorio().Selecionar(getContratoId));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // POST api/<ContratoTrabalhoController>
        [HttpPost]
        public IActionResult Post([FromBody] ContratoTrabalhoDTO dto)
        {
            try
            {
                var regime = new RegimeContratualRepositorio().Selecionar(dto.RegimeId);
                var cargos = new CargoRepositorio().SelecionarCargos(dto.CargosId);
                var colaborador = new ColaboradorRepositorio().Selecionar(dto.ColaboradorId);
                new ContratoTrabalhoRepositorio().Incluir(
                    ContratoTrabalho.Contratar(regime, dto.DataEntrada, cargos, dto.CnpjCtps, colaborador));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // PUT api/<ContratoTrabalhoController>/5
        [HttpPut("{putContratoId}")]
        public IActionResult Put(int putContratoId, [FromBody] ContratoTrabalhoDTO dto)
        {
            try
            {
                var regime = new RegimeContratualRepositorio().Selecionar(dto.RegimeId);
                var cargos = new CargoRepositorio().SelecionarCargos(dto.CargosId);
                var colaborador = new ColaboradorRepositorio().Selecionar(dto.ColaboradorId);
                new ContratoTrabalhoRepositorio().Alterar(ContratoTrabalho.Atualizar(dto, regime, cargos, colaborador, putContratoId));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // DELETE api/<ContratoTrabalhoController>/5
        [HttpDelete("{deleteContratoId}")]
        public IActionResult Delete(int deleteContratoId)
        {
            try
            {
                new ContratoTrabalhoRepositorio().Excluir(deleteContratoId);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{encerrarId}")]
        public IActionResult EncerramentoContrato(int encerrarId, DateTime dataEncerramento)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
