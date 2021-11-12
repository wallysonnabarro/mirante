using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dados.Repositorio;

namespace TechBeauty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        [HttpGet("paginar")]
        public IActionResult GetPagina(int skip, int take = 25)
        {
            return Ok(GeneroReadDto.Paginar(new GeneroRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(new GeneroRepositorio().Selecionar(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] GeneroDto genero)
        {
            try
            {
                new GeneroRepositorio().Incluir(Genero.Criar(genero.Valor));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Genero genero)
        {
            try
            {
                new GeneroRepositorio().Alterar(Genero.Alterar(genero.Valor, id));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                new GeneroRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
