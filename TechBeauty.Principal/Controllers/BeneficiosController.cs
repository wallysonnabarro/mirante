using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Principal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeneficiosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] BeneficioDto beneficio)
        {
            try
            {
                int id = new BeneficioRepositorio().IncluirBeneficio(beneficio);
                return CreatedAtAction(nameof(PegarBenefinio), new { Id = id }, beneficio);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult PegarBenefinio(int id)
        {
            try
            {
                Beneficio beneficio = new BeneficioRepositorio().SelecionarBeneficio(id);
                if (beneficio != null)
                {
                    return Ok(BeneficioDto.CriarBeneficio(beneficio));
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Tabela()
        {
            try
            {
                return Ok(new BeneficioRepositorio().Tabela());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] BeneficioDto beneficio)
        {
            try
            {
                if (new BeneficioRepositorio().SelecionarBeneficio(id) != null)
                {
                    new BeneficioRepositorio().AlterarBeneficio(id, beneficio);
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
        public IActionResult Remover(int id)
        {
            try
            {
                if (new BeneficioRepositorio().SelecionarBeneficio(id) != null)
                {
                    new BeneficioRepositorio().ExcluirBeneficio(id);
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
