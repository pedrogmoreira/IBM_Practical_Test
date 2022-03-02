using Microsoft.AspNetCore.Mvc;
using System;

namespace INSS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class INSSController : ControllerBase
    {
        private readonly ICalculadorInss calculadorInss;

        public INSSController(ICalculadorInss _calculadorInss)
        {
            calculadorInss = _calculadorInss;
        }

        [HttpGet("/CalcaularDescont/{salario}/{data}")]
        public IActionResult CalcularDesconto(decimal salario, DateTime data)
        {
            try
            {
                var desconto = calculadorInss.CalcularDesconto(data, salario);
                return Ok(desconto);
            }
            catch (Exception)
            {
                return BadRequest("O ano especificado não está implementado.");
            }

            
        }
    }
}
