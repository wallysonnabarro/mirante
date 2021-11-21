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
    public class OrdemServicoController : ControllerBase
    {
        // GET: api/<ContratoTrabalhoController>/colecao
        [HttpGet("paginarOrdem/{skip}/{take}")]
        public IActionResult Get(int skip = 0, int take = 25)
        {
            return Ok(OrdemServicoReadDTO.Paginar(new OrdemServicoRepositorio().Paginar(skip, take)));
        }

        // GET api/<ContratoTrabalhoController>/5
        [HttpGet("{ordemid}")]
        public IActionResult Get(int ordemid)
        {
            try
            {
                return Ok(OrdemServicoReadDTO.Converter(new OrdemServicoRepositorio().Selecionar(ordemid)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        //POST api/<ContratoTrabalhoController>
        [HttpPost]
        public IActionResult Post([FromBody] OrdemServicoDTO dto)
        {
            try
            {
                int id = new OrdemServicoRepositorio().AbrirOrdemServico(OrdemServico.Criar(dto));
                return CreatedAtAction(nameof(Get), new { Id = id}, dto);
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // PUT api/<ContratoTrabalhoController>/5
        [HttpPut("{putOrdemid}")]
        public IActionResult Put(int putOrdemid, [FromBody] OrdemServicoDTO dto)
        {
            try
            {
                //var cliente = new ClienteRepositorio().Selecionar(dto.ClienteID);
                //new OrdemServicoRepositorio().Incluir(OrdemServico.Criar(dto, cliente));//concertar com metodo de atualizar
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // DELETE api/<ContratoTrabalhoController>/5
        [HttpDelete("{deletarOrdemid}")]
        public IActionResult Delete(int deletarOrdemid)
        {
            try
            {
                //new OrdemServicoRepositorio().Excluir(deletarOrdemid);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut("{encerrarOsId}")]
        public IActionResult EncerramentoOS(int encerrarOsId)
        {
            try
            {
                new OrdemServicoRepositorio().AlterarStatus(encerrarOsId);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
