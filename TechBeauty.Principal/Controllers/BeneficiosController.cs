
using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }


        [HttpGet("{id}")]
        public IActionResult PegarBenefinio(int id)
        {
            try
            {
                return base.Ok(Beneficio.CoverteDto(new BeneficioRepositorio().Selecionar(id)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult Tabela(int skip = 0, int take = 25)
        {
            return Ok(BeneficioReadDto.Paginar(new BeneficioRepositorio().Paginar(skip, take)));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] BeneficioDto beneficio)
        {
            try
            {
                if (new BeneficioRepositorio().Selecionar(id) != null)
                {
                    new BeneficioRepositorio().Alterar(Beneficio.Alterar(beneficio));
                }
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
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
                }
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
