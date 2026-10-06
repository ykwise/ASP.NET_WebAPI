using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class GreetController : ControllerBase
{
    [HttpGet("{name}")]

    public string Get(string name)
    {
        return $"Hello {name}!";
    }

}