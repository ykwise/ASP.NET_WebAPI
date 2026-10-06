using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class StudentConfirmController : ControllerBase
{
    [HttpPost]

    public StudentMes Post(StudentReq request)
    {
        return new StudentMes("Student created successfully",request.Name,request.Age,request.Course);
    }

    public sealed record StudentReq(string Name,int Age,string Course);
    public sealed record StudentMes(string Message,string Name,int Age,string Course);
}