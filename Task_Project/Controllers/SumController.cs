using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class SumController : ControllerBase
{
    [HttpPost]

    public int Post(SumReq request)
    {
        return  request.A + request.B;
    }


    public sealed record SumReq(int A,int B);
}