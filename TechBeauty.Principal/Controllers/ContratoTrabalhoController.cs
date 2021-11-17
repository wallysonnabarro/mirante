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
    public class ContratoTrabalhoController : ControllerBase
    {
        // GET: api/<ContratoTrabalhoController>/colecao
        [HttpGet("paginarContrato/{skip}/{take}")]
        public IActionResult Get(int skip = 0, int take = 25)
        {
            return Ok(new ContratoTrabalhoRepositorio().PaginarJoin(skip, take));
        }

        // GET api/<ContratoTrabalhoController>/5
        [HttpGet("{getContratoId}")]
        public IActionResult Get(int getContratoId)
        {
            try
            {
                return Ok(new ContratoTrabalhoRepositorio().SelecionarJoin(getContratoId));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // POST api/<ContratoTrabalhoController>
        [HttpPost]
        public IActionResult Post([FromBody] ContratoTrabalhoDTO dto)
        {
            try
            {
                new CargoContratoTrabalhoRepositorio().IncluirMuitos(dto.CargosId,
                    new ContratoTrabalhoRepositorio().Incluir(ContratoTrabalho.Contratar(dto)));
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        // PUT api/<ContratoTrabalhoController>/5
        [HttpPut("{putContratoId}")]
        public IActionResult Put(int putContratoId, [FromBody] ContratoTrabalhoDTO dto)
        {
            try
            {
                new ContratoTrabalhoRepositorio().Alterar(ContratoTrabalho.Atualizar(dto, putContratoId));
                new CargoContratoTrabalhoRepositorio().AlterarTudo(putContratoId, dto.CargosId);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }


        [HttpPut("{encerrarId}/{dataEncerramento}")]
        public IActionResult EncerramentoContrato(int encerrarId, DateTime dataEncerramento)
        {
            try
            {
                new ContratoTrabalhoRepositorio().EncerrarContrato(encerrarId, dataEncerramento);
                return Ok();
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
