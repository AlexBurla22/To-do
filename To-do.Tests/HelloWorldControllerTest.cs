using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace To_dos.Controllers;

public class HelloWorldControllerTest
{
    private readonly HelloWorldController _controller;

    public HelloWorldControllerTest(){
        _controller = new HelloWorldController();
    }

    [Fact]
    public void GetTodosTest()
    {
        // var actionResult = _controller.GetTodos();
        var actionResult = _controller.GetTodos();
        
        Assert.IsType<OkObjectResult>(actionResult);
    }
}