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
                new GeneroRepositorio().SelecionarTudo();
                return Ok();
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
                Genero genero = new GeneroRepositorio().Selecionar(id);
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
        public IActionResult Post([FromBody] Genero genero)
        {
            try
            {
                 new GeneroRepositorio().Incluir(genero);
                    
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Genero genero)
        {
            try
            {
                if (new GeneroRepositorio().Selecionar(id) != null)
                {
                    new GeneroRepositorio().Alterar(genero);
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
                if (new GeneroRepositorio().Selecionar(id) != null)
                {
                    new GeneroRepositorio().Excluir(id);
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
