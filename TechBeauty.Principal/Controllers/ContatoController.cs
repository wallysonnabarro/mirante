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
    public class ContatoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] ContatoDTO contato)
        {
            try
            {
                new ContatoRepositorio().Incluir(Contato.Criar(contato.PessoaId, contato));
                return Ok();
            }
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar/{skip}/{take}")]
        public IActionResult ColecaoContatos(int skip = 0, int take = 25)
        {
            return Ok(ContatoReadDTO.Paginar(new ContatoRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarPorID(int id)
        {
            try
            {
                return Ok(new ContatoRepositorio().Selecionar(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("contatoPessoa/{pessoaId}")]
        public IActionResult SelecionarPorPeassoaId(int pessoaId)
        {
            try
            {
                return Ok(new ContatoRepositorio().SelecionarContatoPessoa(pessoaId));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarContato(int id, [FromBody] ContatoDTO contato)
        {
            try
            {
                new ContatoRepositorio().Alterar(Contato.AlterarContato(id, contato));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarContato(int id)
        {
            try
            {
                new ContatoRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
