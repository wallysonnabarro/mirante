using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] Cargo cargo)
        {
            try
            {
                //int id = new CargoRepositorio().Incluir(cargo);
                //return CreatedAtAction(nameof(RecuperarCargoId), new { Id = id }, cargo);
                new CargoRepositorio().Incluir(cargo);
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult ColecaoCargos()
        {
            try
            {
                return Ok(new CargoRepositorio().SelecionarTudo());
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCargoId(int id)
        {
            try
            {
                Cargo cargo = new CargoRepositorio().Selecionar(id);
                if (cargo != null)
                {
                    return Ok(cargo);
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCargo(int id, [FromBody] Cargo cargo)
        {
            try
            {
                if (new CargoRepositorio().Selecionar(id) != null)
                {
                    new CargoRepositorio().Alterar(cargo);
                    return NoContent();
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCargo(int id)
        {
            try
            {
                if (new CargoRepositorio().Selecionar(id) != null)
                {
                    new CargoRepositorio().Excluir(id);
                    return NoContent();
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}
