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
    [ApiController]
    [Route("[controlller]")]
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult Criar([FromBody] UsuarioDTO usuario)
        {
            try
            {
                var cargo = new CargoRepositorio().Selecionar(usuario.CargoId);
                new UsuarioRepositorio().Incluir(Usuario.Criar(usuario, cargo));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }

        }

        [HttpGet("paginar")]
        public IActionResult Tabela(int skip = 0, int take = 25)
        {
            try
            {
                return Ok(UsuarioDTO.Paginar(new UsuarioRepositorio().Paginar(skip, take)));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("validar")]
        public IActionResult ValidarUsuario([FromBody] UsuarioDTO dto)
        {
            try
            {
                return Ok(new UsuarioRepositorio().ValidarUsuario(dto));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("atualizarUser/{id}")]
        public IActionResult AtualizarUser(int id, string user)
        {
            try
            {
                new UsuarioRepositorio().AtualizarUsuario(id, user);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("atualizarPassw/{id}")]
        public IActionResult AtualizarPassword(int id, string password)
        {
            try
            {
                new UsuarioRepositorio().AlterarSenha(id, password);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("atualizarCarg/{id}")]
        public IActionResult AtualizarCargo(int id, int cargoId)
        {
            try
            {
                new UsuarioRepositorio().AlterarCargoUsuario(id, cargoId);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Deletar(int id)
        {
            try
            {
                new UsuarioRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
