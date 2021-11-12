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
                var endereco = Endereco.Criar(colaborador);
                int id = new EnderecoRepositorio().Incluir(endereco);
                endereco.IncluirId(id);
                new ColaboradorRepositorio().Incluir(Colaborador.Criar(colaborador, endereco));
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpGet("paginar")]
        public IActionResult Tabela(int skip = 0, int take = 25)
        {
            try
            {
                return Ok(ColaboradorReadDTO.Paginar(new ColaboradorRepositorio().Paginar(skip, take)));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
