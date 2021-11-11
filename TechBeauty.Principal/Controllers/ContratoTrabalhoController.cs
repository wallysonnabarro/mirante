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
        [HttpGet("colecao")]
        public IActionResult Get(int skip = 0, int take = 25)
        {
            return Ok(new ContratoTrabalhoRepositorio().Paginar(skip, take));
        }

        // GET api/<ContratoTrabalhoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(new ContratoTrabalhoRepositorio().Selecionar(id));
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContratoTrabalhoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
