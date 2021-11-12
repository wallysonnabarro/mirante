using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        [HttpPost("incluir")]
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

        [HttpGet("{skip}/{take}")]
        public IActionResult ColecaoCargos(int skip = 0, int take = 25)
        {
            return Ok(CargoReadDTO.Paginar(new CargoRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperarCargoId(int Id)
        {
            try
            {
                return Ok(new CargoRepositorio().Selecionar(Id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{cargoid}")]
        public IActionResult AtualizarCargo(int cargoid, [FromBody] CargoDto cargo)
        {
            try
            {
                new CargoRepositorio().Alterar(Cargo.AlterarCargo(cargo, cargoid));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{deletarid}")]
        public IActionResult DeletarCargo(int deletarid)
        {
            try
            {
                new CargoRepositorio().Excluir(deletarid);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
