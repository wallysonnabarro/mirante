using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dados.Repositorio;

namespace TechBeauty.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        [HttpGet("paginar")]
        public IActionResult GetPagina(int skip)
        {
            try
            {
                return Ok(GeneroReadDto.Paginar(new GeneroRepositorio().Paginar(skip)));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(new GeneroRepositorio().Selecionar(id));
            }
            catch (Exception)
            {
                return NotFound();
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
            catch (Exception)
            {
                return Accepted();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Genero genero)
        {
            try
            {
                new GeneroRepositorio().Alterar(Genero.Alterar(genero.Valor, id));
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                new GeneroRepositorio().Excluir(id);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
