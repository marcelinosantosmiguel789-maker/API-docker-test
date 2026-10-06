using Microsoft.AspNetCore.Mvc;


namespace API_docker_Test.Controllers;

[Route("api/[controller]/[action]")]
public class ProductsController : Controller
{
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        return(id == null) ? new NotFoundResult() : new OkObjectResult(id);
    }
}

