using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class EmployeeController : ControllerBase
{
    [HttpPost]

    public Employee Post(EmpRequest request)
    {
        if(request.Id == 101)
        {
            return new Employee(request.Id,"Rahul","IT");
            
        }
        return new Employee(0,"Not Found","");
    }


    public sealed record EmpRequest(int Id);
    public sealed record Employee(int Id,string Name,string Department);
}