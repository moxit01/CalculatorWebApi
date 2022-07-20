using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLogic;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorWebApi.Controllers
{



    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        // GET: /<controller>/
        [HttpGet]
        public double Add([FromQuery] double num1, [FromQuery] double num2)
        {
            return AddLogic.Addition(num1, num2);
        }

    }
}

