using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class LanguageController : ControllerBase
{
    [HttpGet]

    public string[] Get()
    {
        return ["C#",
            "Java",
            "Python",
            "JavaScript",
            "Go"];
    }
    
}