using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaixaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] CaixaDTO dto)
        {
            try
            {
                var usuario = new UsuarioRepositorio().Selecionar(dto.UsuarioID);
                new CaixaRepositorio().Incluir(Caixa.AbrirCaixa(dto.SaldoInicial,usuario));
                return Ok();
            }
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult Paginar(int skip = 0, int take = 25)
        {
            return Ok(CaixaReadDTO.Paginar(new CaixaRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarPorID(int id)
        {
            try
            {
                return Ok(new CaixaRepositorio().Selecionar(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCaixa(int id)
        {
            try
            {
                
                new CaixaRepositorio().Alterar(Caixa.FecharCaixaPagamento(new PagamentoRepositorio().SelecionarID(id),id));
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
                new CaixaRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
