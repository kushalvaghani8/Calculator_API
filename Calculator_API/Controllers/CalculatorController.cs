using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculator_API;
using Calculator_Logic;

namespace Calculator_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase

    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }


        [HttpPost("Add")] //add for api
        public double Add(double left, double right)
        {
            return Calculator.Add(left, right);
        }

        [HttpPost("Subtract")] //subtract for api
        public double Subtract(double left, double right)
        {
            return Calculator.Subtract(left, right);
        }

        [HttpPost("Multiply")] // multiply for api
        public double Multiply(double left, double right)
        {
            return Calculator.Multiply(left, right);
        }


        [HttpPost("Divide")]//divide for api
        public IActionResult Divide(double left, double right)
        {
            try
            {
                return Ok(Calculator.Divide(left, right));
            }
            catch (DivideByZeroException err) //catching error for number divided by zero
            {
                Console.WriteLine("Enter a valid number possibly non-zero value");
                return BadRequest();
            }
        }

    }
}