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
    public class EscalaController : ControllerBase
    {
        [HttpGet("paginar/{skip}/{take}")]
        public IActionResult GetPagina(int skip, int take = 25)
        {
            return Ok(new EscalaRepositorio().PaginarPorDataAtual(skip, take));
        }

        [HttpGet("paginar/{colaboradorId}/{skip}/{take}")]
        public IActionResult GetPaginaPorColaborador(int colaboradorId, int skip, int take = 25)
        {
            return Ok(new EscalaRepositorio().PaginarPorColaborador(colaboradorId, skip, take));
        }

        [HttpPost]
        public IActionResult Post([FromBody] EscalaDTO dto)
        {
            try
            {
                new EscalaRepositorio().Incluir(Escala.Criar(dto));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
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


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EscalaDTO dto)
        {
            try
            {
                new EscalaRepositorio().Alterar(Escala.ModificarEscala(dto, id));
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
