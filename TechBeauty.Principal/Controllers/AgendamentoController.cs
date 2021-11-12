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
                var servico = new ServicoRepositorio().Selecionar(dto.ServicoID);
                var colaborador = new ColaboradorRepositorio().Selecionar(dto.ColaboradorID);
                var os = new OrdemServicoRepositorio().Selecionar(dto.OrdemSID);
                new AgendamentoRepositorio().Incluir(Agendamento.Criar(dto, servico, colaborador, os));
                return Ok();
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
                return Ok(new AgendamentoRepositorio().Selecionar(id));
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
                var colaborador = new ColaboradorRepositorio().Selecionar(dto.ColaboradorID);
                var os = new OrdemServicoRepositorio().Selecionar(dto.OrdemSID);
                new AgendamentoRepositorio().Alterar(Agendamento.RemarcarAgendamento(dto, colaborador,os, id));
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
