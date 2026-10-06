using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class SquareController : ControllerBase
{
    [HttpPost]

    public int Post(Square request)
    {
        return  request.Num * request.Num;
    }


    public sealed record Square(int Num);
}