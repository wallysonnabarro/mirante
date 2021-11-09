
using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Financeiro;

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
                new BeneficioRepositorio().Incluir(Beneficio.GerarBeneficio(beneficio));
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


        [HttpGet("{id}")]
        public IActionResult PegarBenefinio(int id)
        {
            try
            {
                if (new BeneficioRepositorio().Selecionar(id) != null)
                {
                    return base.Ok(Beneficio.CoverteDto(new BeneficioRepositorio().Selecionar(id)));
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("paginar")]
        public IActionResult Tabela(int skip = 0)
        {
            try
            {
                return Ok(BeneficioReadDto.Paginar(new BeneficioRepositorio().Paginar(skip)));
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
                if (new BeneficioRepositorio().Selecionar(id) != null)
                {
                    new BeneficioRepositorio().Alterar(Beneficio.Alterar(beneficio));
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
