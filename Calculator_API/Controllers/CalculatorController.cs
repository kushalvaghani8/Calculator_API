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


        [HttpPost("Add")]
        public double Add(double left, double right)
        {
            return Calculator.Add(left, right);
        }

        [HttpPost("Subtract")]
        public double Subtract(double left, double right)
        {
            return Calculator.Subtract(left, right);
        }

        [HttpPost("Multiply")]
        public double Multiply(double left, double right)
        {
            return Calculator.Multiply(left, right);
        }

    }
}