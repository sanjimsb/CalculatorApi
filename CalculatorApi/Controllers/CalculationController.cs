using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Calculation;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Calculator_Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorApi.Controllers
{
    
    [Route("api/[controller]")]
    public class CalculationController : Controller
    {

        /// <summary>
        /// Does Calculation
        /// </summary>
        /// <remarks>
        ///     Sample request:
        /// 
        ///     POST api/Calculation
        ///     {        
        ///       "left": 1,
        ///       "right": 1,
        ///       "calculation": "+"        
        ///     }
        /// </remarks>
        // POST api/values
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Produces("application/json")]
        public double Post([FromBody] Calculator_Models.Calculate value)
        {
            double result = 0;
            try
            {
                switch(value.Calculation)
                {
                    case "+":
                        result = Calculation.Calculate.Add((double)value.Left, (double)value.Right);
                       break;
                    case "-":
                        result = Calculation.Calculate.Subtraction((double)value.Left, (double)value.Right);
                        break;
                    case "/":
                        result = Calculation.Calculate.Division((double)value.Left, (double)value.Right);
                        break;
                    case "*":
                        result = Calculation.Calculate.Multiplication((double)value.Left, (double)value.Right);
                        break;

                }
                return result;
                
            }
            catch(Exception)
            {
                Console.WriteLine("error");
            }
                
            return 0;

        }

    }
}

