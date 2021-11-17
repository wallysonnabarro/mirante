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
    public class ColaboradorController : Controller
    {
        [HttpPost]
        public ActionResult Criar([FromBody] ColaboradorDTO colaborador)
        {
            try
            {
                int id = new ColaboradorRepositorio().Incluir(Colaborador.Criar(
                    colaborador,
                    new EnderecoRepositorio().IncluirComRetorno(Endereco.Criar(colaborador))));

                new ContatoRepositorio().IncluirContato(id, colaborador);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("paginar/{skip}/{take}")]
        public IActionResult Tabela(int skip = 0, int take = 25)
        {
            try
            {

                return Ok(new ColaboradorRepositorio().PaginarInnerJoin(skip, take));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarColaborador(int id, [FromBody] ColaboradorAtualizarDto colaborador)
        {
            try
            {
                new ColaboradorRepositorio().Alterar(Colaborador.Atualizar(colaborador));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("atualizarEndereco")]
        public IActionResult AtualizarEnderecoColaborador([FromBody] EnderecoReadDTO dto)
        {
            try
            {
                new EnderecoRepositorio().Alterar(Endereco.Aterar(dto));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Selecionar(int id)
        {
            try
            {
                //Implementar a troca de Colaborador para Colaborador Read
                return Ok(new ColaboradorRepositorio().SelecaoUnica(id));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
