using Microsoft.AspNetCore.Http;
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
    public class RegimeContratualController : Controller
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] RegimeContratualDTO regime)
        {
            try
            {
                new RegimeContratualRepositorio().Incluir(RegimeContratual.Criar(regime));
                return Ok();
            }
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult ColecaoRegimes(int skip = 0, int take = 25)
        {
            return Ok(RegimeContratualReadDTO.Paginar(new RegimeContratualRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                return Ok(RegimeContratualReadDTO.Converte(new RegimeContratualRepositorio().Selecionar(id)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

   

        [HttpDelete("{id}")]
        public IActionResult ExcluirRegime(int id)
        {
            try
            {
                new RegimeContratualRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
