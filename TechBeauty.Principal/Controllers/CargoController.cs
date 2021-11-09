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
        public IActionResult Incluir([FromBody] CargoDto cargo)
        {
            try
            {
                new CargoRepositorio().Incluir(Cargo.CriarCargo(cargo));
                return Ok();
            }
            catch (Exception)
            {
                return Accepted();
            }
        }

        [HttpGet("paginar")]
        public IActionResult ColecaoCargos(int skip = 0)
        {
            return Ok(new CargoRepositorio().Paginar(skip));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCargoId(int id)
        {
            try
            {
                return Ok(new CargoRepositorio().Selecionar(id));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCargo(int id, [FromBody] CargoDto cargo)
        {
            try
            {
                new CargoRepositorio().Alterar(Cargo.AlterarCargo(cargo, id));
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCargo(int id)
        {
            try
            {
                new CargoRepositorio().Excluir(id);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
