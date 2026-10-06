using API_docker_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_docker_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    [HttpPost]
    public IActionResult Login(LoginModel model)
    {
        if (model.Email == "teste@email.com" &&
            model.Password == "123456")
        {
            return Ok(new
            {
                message = "Login realizado com sucesso!"
            });
        }

        return Unauthorized(new
        {
            message = "Email ou senha inválidos."
        });
    }
}