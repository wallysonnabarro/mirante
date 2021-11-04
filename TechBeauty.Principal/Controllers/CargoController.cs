using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dados.Repositorio;

namespace TechBeauty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] CargoDto cargo)
        {
            try
            {
                int id = new CargoRepositorio().Incluir(cargo);
                return CreatedAtAction(nameof(RecuperarCargoId), new { Id = id }, cargo);
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
                return Ok(new CargoRepositorio().Tabela());
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
                CargoDto cargoDto = new CargoRepositorio().PegarCargo(id);
                if (cargoDto != null)
                {
                 return Ok(cargoDto);
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCargo(int id, [FromBody] CargoDto cargo)
        {
            try
            {
                if (new CargoRepositorio().PegarCargo(id) != null)
                {
                    new CargoRepositorio().Atualizar(id, cargo);
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
                if (new CargoRepositorio().PegarCargo(id) != null)
                {
                    new CargoRepositorio().Remover(id);
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
