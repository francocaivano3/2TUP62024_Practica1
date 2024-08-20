using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej10controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int start, int end)
        {
            int difference = end - start;
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            if (difference < 1000)
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenNumbers.Add(i);
                    }
                    else
                    {
                        oddNumbers.Add(i);
                    }
                }

                var resultado = new Dictionary<string, List<int>>
                {
                    { "OddNumbers", oddNumbers },
                    { "EvenNumbers", evenNumbers }
                };

                return Ok(resultado);
            }
            else
            {
                return BadRequest("La diferencia entre el número de fin y el de inicio es mayor a 1000");
            }
        }
    }
}
