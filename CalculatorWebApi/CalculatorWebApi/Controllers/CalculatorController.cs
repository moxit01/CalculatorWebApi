using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLogic;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorWebApi.Controllers
{




    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        // GET: /<controller>/
        [HttpGet("Add")]
        public double Add([FromQuery] double num1, [FromQuery] double num2)
        {
            return Logic.Addition(num1, num2);
        }

        [HttpGet("Subtract")]
        public double Subtract([FromQuery] double num1, [FromQuery] double num2)
        {
            return Logic.Subtraction(num1, num2);
        }

        [HttpGet("Multiply")]
        public double Multiply([FromQuery] double num1, [FromQuery] double num2)
        {
            return Logic.Multiplication(num1, num2);
        }

        [HttpGet("Divide")]
        public double Divide([FromQuery] double num1, [FromQuery] double num2)
        {
            return Logic.Divide(num1, num2);
        }




        //[HttpGet]
        //public double Multiply([FromQuery] double num1, [FromQuery] double num2)
        //{
        //    return MultiplyLogic.Multiplication(num1, num2);
        //}


    }
}

