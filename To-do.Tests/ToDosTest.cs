using Microsoft.AspNetCore.Mvc;
using System.Net;
using To_dos.Controllers;
using To_dos.Models;

public class ToDosTest
{
    private readonly ToDosController _controller;

    public ToDosTest(){
        _controller = new ToDosController();
    }

    [Fact]
    public void GetTosDoList_ReturnsOk()
    {
        var actionResult = _controller.GetToDosList();
        Assert.IsType<OkObjectResult>(actionResult as OkObjectResult);
    }

    [Fact]
    public void GetToDosList_ReturnsAllItems(){
        var actionResult = _controller.GetToDosList() as OkObjectResult;
        var list = Assert.IsType<List<ToDoItem>>(actionResult.Value);
        Assert.Equal(6, list.Count);
    }
}