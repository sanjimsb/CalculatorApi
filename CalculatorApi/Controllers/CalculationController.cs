using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
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

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

