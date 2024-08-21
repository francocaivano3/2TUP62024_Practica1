using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numbers)
    {
        var result =
           from number in numbers
           where number * number > 20
           select number;

        List<string> originalSquares = new List<string>();
        foreach (var number in result.ToList())
        {
            string strNumb = number.ToString();
            int square = number * number;
            string strSquare = square.ToString();
            originalSquares.Add($"{strNumb} - {strSquare}");
        }
        return Ok(result);
    }
}