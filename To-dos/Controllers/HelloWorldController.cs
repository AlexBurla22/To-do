using Microsoft.AspNetCore.Mvc;

namespace To_dos.Controllers;

[ApiController]
[Route("[controller]")]

public class HelloWorldController: Controller{
    [HttpGet(Name = "GetTodos")]
    public IActionResult GetTodos(){
        return Ok(new HelloWorld("message"));
        }
}