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
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult ColecaoCargos(int skip = 0, int take = 25)
        {
            return Ok(CargoReadDto.Paginar(new CargoRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCargoId(int id)
        {
            try
            {
                return Ok(new CargoRepositorio().Selecionar(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCargo(int id, [FromBody] CargoDto cargo)
        {
            try
            {
                new CargoRepositorio().Alterar(Cargo.AlterarCargo(cargo, id));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCargo(int id)
        {
            try
            {
                new CargoRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
