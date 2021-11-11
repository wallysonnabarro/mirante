using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoContatoController : ControllerBase
    {
        // GET: api/<TipoContatoController>/colecao
        [HttpGet("colecao")]
        public IActionResult Get(int skip = 0, int take = 25)
        {
            return Ok(TipoContatoReadDto.Colecao(new TipoContatoRepositorio().Paginar(skip, take)));
        }

        // GET api/<TipoContatoController>/5
        [HttpGet("{id}")]
        public IActionResult GetTipo(int id)
        {
            try
            {
                return Ok(new TipoContatoRepositorio().Selecionar(id).Valor);
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // POST api/<TipoContatoController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            try
            {
                new TipoContatoRepositorio().Incluir(TipoContato.Criar(value));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // PUT api/<TipoContatoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            try
            {
                new TipoContatoRepositorio().Alterar(TipoContato.AtualizarTipoContato(value, id));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // DELETE api/<TipoContatoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                new TipoContatoRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
