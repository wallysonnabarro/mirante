using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;

namespace TechBeauty.Principal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComissaoController : Controller
    {
        [HttpGet("{Id}")]
        public IActionResult Comissao(int colaboradorId)
        {
            try
            {
                return Ok(new ComissaoRepositorio().ListagemComissao(colaboradorId));
            }
            catch (Exception e)
            {

                return ValidationProblem(e.Message);
            }
        }
       
    }
}
