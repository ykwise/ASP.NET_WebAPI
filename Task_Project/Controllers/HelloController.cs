using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class HelloController : ControllerBase
{
    [HttpGet]

    public string get()
    {
        return "Hello, welcome to ASP.NET Core Web API!";
    }

}