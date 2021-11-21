using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo.Financeiro;

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComissaoController : Controller
    {
        [HttpGet("{colaboradorId}")]
        public IActionResult Comissoes(int colaboradorId)
        {
            try
            {
                return Ok(ComissaoReadDTO.Paginar(new ComissaoRepositorio().ListagemComissao(colaboradorId)));
            }
            catch (Exception e)
            {

                return ValidationProblem(e.Message);
            }
        }
        
        [HttpGet("totalComissoes/{colaboradorId}")]
        public IActionResult TotalComissoes(int colaboradorId)
        {
            try
            {
                return Ok(Comissao.TotalComissoes(new ComissaoRepositorio().ListagemComissao(colaboradorId)));
            }
            catch (Exception e)
            {

                return ValidationProblem(e.Message);
            }
        }
        
        [HttpPut("pagarComissao/{id}")]
        public IActionResult PagarComissao(int id)
        {
            try
            {//Implementar o registro no caixa
                return Ok(Comissao.TotalComissoes(new ComissaoRepositorio().ListagemComissao(id)));
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
