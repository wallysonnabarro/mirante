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
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new GeneroRepositorio().Tabela());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Genero genero = new GeneroRepositorio().PegarGenero(id);
                if (genero != null)
                {
                    return Ok(GeneroDto.CriarGenero(genero.Valor));
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] GeneroDto generoDto)
        {
            try
            {
                int id = new GeneroRepositorio().Incluir(generoDto);
                return CreatedAtAction(nameof(Get), new { Id = id}, generoDto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] GeneroDto generoDto)
        {
            try
            {
                if (new GeneroRepositorio().PegarGenero(id) != null)
                {
                    new GeneroRepositorio().Alterar(id, generoDto.Valor);
                    return NoContent();
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (new GeneroRepositorio().PegarGenero(id) != null)
                {
                    new GeneroRepositorio().Remover(id);
                    return NoContent();
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
