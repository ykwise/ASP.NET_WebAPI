using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{
    [HttpGet]

    public Student Get()
    {
        return new Student(101,"Rahul","BTech",21);
    }

    public sealed record Student(int Id,string Name,string Course,int Age);
}