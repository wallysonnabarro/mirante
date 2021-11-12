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
    public class PagamentoController : Controller
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] PagamentoDTO pagamento)
        {
            try
            {
                var os = new OrdemServicoRepositorio().Selecionar(pagamento.OrdemServicoID);
                new PagamentoRepositorio().Incluir(Pagamento.Criar(pagamento,os));
                return Ok();
            }
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult ColecaoPagamentos(int skip = 0, int take = 25)
        {
            return Ok(PagamentoReadDTO.Paginar(new PagamentoRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                return Ok(new PagamentoRepositorio().Selecionar(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPagamento(int id, [FromBody] PagamentoDTO pagamento)
        {
            try
            {
                var os = new OrdemServicoRepositorio().Selecionar(pagamento.OrdemServicoID);
                new PagamentoRepositorio().Incluir(Pagamento.Alterar(pagamento,os, id));
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
                new PagamentoRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
