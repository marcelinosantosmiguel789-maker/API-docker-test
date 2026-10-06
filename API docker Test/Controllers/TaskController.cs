using Microsoft.AspNetCore.Mvc;

namespace API_docker_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("API funcionando!");
    }
}