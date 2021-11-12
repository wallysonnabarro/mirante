using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalaController : ControllerBase
    {
        [HttpGet("paginar")]
        public IActionResult GetPagina(int skip, int take = 25)
        {
            return Ok(EscalaReadDTO.Paginar(new EscalaRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(new EscalaRepositorio().Selecionar(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] EscalaDTO dto)
        {
            try
            {
                var colaborador = new ColaboradorRepositorio().Selecionar(dto.ColaboradorID);
                new EscalaRepositorio().Incluir(Escala.Criar(dto, colaborador));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EscalaDTO dto)
        {
            try
            {
                var colaborador = new ColaboradorRepositorio().Selecionar(dto.ColaboradorID);
                new EscalaRepositorio().Alterar(Escala.ModificarEscala(dto, id, colaborador));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                new EscalaRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
