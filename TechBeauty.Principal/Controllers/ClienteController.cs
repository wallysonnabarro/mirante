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
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] ClienteDTO cliente)
        {
            try
            {
                int id = new ClienteRepositorio().Incluir(Cliente.Criar(cliente));
                new ContatoRepositorio().IncluirContatoCliente(id, cliente);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult ColecaoClientes(int skip = 0, int take = 25)
        {
            return Ok(ClienteReadDto.Paginar(new ClienteRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarPorID(int id)
        {
            try
            {
                return Ok(ClienteReadDto.Cliente(new ClienteRepositorio().SelecionarCliente(id)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(int id, [FromBody] ClienteDTO cliente)
        {
            try
            {
                new ClienteRepositorio().AtualizarCliente(Cliente.AlterarCliente(cliente, id));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirCliente(int id)
        {
            try
            {
                new ClienteRepositorio().ExcluirCascata(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
