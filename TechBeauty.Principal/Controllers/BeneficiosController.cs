using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dados.Repositorio;

using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Principal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeneficiosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] Beneficio beneficio)
        {
            try
            {
                new BeneficioRepositorio().Incluir(beneficio);
                return Ok();
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
                Dominio.Modelo.Beneficio beneficio = new BeneficioRepositorio().Selecionar(id);
                if (beneficio != null)
                {
                    return base.Ok(Dominio.Dtos.Beneficio.CriarBeneficio(beneficio));
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
                return Ok(new BeneficioRepositorio().SelecionarTudo());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Beneficio beneficio)
        {
            try
            {
                if (new BeneficioRepositorio().Selecionar(id) != null)
                {
                    new BeneficioRepositorio().Alterar(beneficio);
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
                if (new BeneficioRepositorio().Selecionar(id) != null)
                {
                    new BeneficioRepositorio().Excluir(id);
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
