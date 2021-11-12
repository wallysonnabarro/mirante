using Microsoft.AspNetCore.Mvc;
using System;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : Controller
    {
        [HttpPost]
        public IActionResult CriarServico([FromBody] ServicoDTO servico)
        {
            try
            {
                new ServicoRepositorio().Incluir(Servico.Criar(servico));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }


        [HttpGet("paginar")]
        public IActionResult Paginar(int skip = 0, int take = 25)
        {
            return Ok(ServicoReadDTO.Paginar(new ServicoRepositorio().Paginar(skip, take)));
        }

        [HttpGet("{id}")]
        public IActionResult Selecionar(int id)
        {
            try
            {
                return Ok(ServicoDTO.CriarServico(new ServicoRepositorio().Selecionar(id)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, [FromBody] ServicoReadDTO dto)
        {
            try
            {
                new ServicoRepositorio().Alterar(Servico.Alterar(dto, id));
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
                new ServicoRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
