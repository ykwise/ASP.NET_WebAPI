using Microsoft.AspNetCore.Mvc;

namespace Task_Project.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    [HttpGet]

    public Product Get()
    {
        return new Product(1,"Laptop",75000,"Dell");
    }



    public sealed record Product(int Id,string name,int price,string brand);

}