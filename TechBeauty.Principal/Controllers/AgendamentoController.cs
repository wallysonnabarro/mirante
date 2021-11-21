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
    public class AgendamentoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Incluir([FromBody] AgendamentoDTO dto)
        {
            try
            {
                int id = new AgendamentoRepositorio().Agendar(Agendamento.Criar(dto));
                return CreatedAtAction(nameof(SelecionarPorID), new { Id = id }, dto);
            }
            catch (ArgumentException e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("paginar")]
        public IActionResult ColecaoAgendada(int skip = 0, int take = 25)
        {
            return Ok(AgendamentoReadDTO.Paginar(new AgendamentoRepositorio().Paginar(skip, take)));
        }

        [HttpGet("selecionar")]
        public IActionResult SelecionarPorID(int id)
        {
            try
            {
                return Ok(AgendamentoReadDTO.Selecionar(new AgendamentoRepositorio().Selecionar(id)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpGet("concluirAgendamento/{id}")]
        public IActionResult ConcluirAgendamento(int id)
        {
            try
            {
                new AgendamentoRepositorio().ConcluirAgendamento(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Remarcar(int id, [FromBody] AgendamentoDTO dto)
        {
            try
            {
                new AgendamentoRepositorio().Alterar(Agendamento.RemarcarAgendamento(dto, id));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("iniciar/{id}")]
        public IActionResult IniciarioServicoAgendado(int id)
        {
            try
            {
                new AgendamentoRepositorio().Iniciar(id);
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
                new AgendamentoRepositorio().Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
