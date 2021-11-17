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
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult Criar([FromBody] UsuarioDTO usuario)
        {
            try
            {
                new UsuarioRepositorio().Incluir(Usuario.Criar(usuario));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }

        }

        [HttpGet("{skip}/{take}")]
        public IActionResult Tabela(int skip = 0, int take = 25)
        {
            try
            {
                return Ok(UsuarioReadDTO.Paginar(new UsuarioRepositorio().Paginar(skip, take)));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("validar")]
        public IActionResult ValidarUsuario([FromBody] UsuarioValidarDto dto)
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

        [HttpPut("atualizarUser")]
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

        [HttpPut("atualizarPassw")]
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

        [HttpPut("atualizarCarg")]
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

        [HttpDelete("{id}")]
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
