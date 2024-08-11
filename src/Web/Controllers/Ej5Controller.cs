using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5controller : ControllerBase
{

    [HttpGet]
    public string Get(string dia)
    {
        string[] diasSemana = ["lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo"];
        int resultIndex = -1;
        dia = dia.Trim().ToLower();
        for (int i = 0; i < diasSemana.Length; i++)
        {
            if(dia == diasSemana[i])
            {
                resultIndex = i;
            }
        }

        if (resultIndex == -1)
        {
            return "404: No se encontró";
        }
        else if (resultIndex == 5 || resultIndex == 6)
        {
            return "El día ingresado pertenece al fin de semana";
        } else
        {
            return "El día ingresado es un día de semana";
        }
    }
}
