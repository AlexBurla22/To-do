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
        Assert.IsType<OkObjectResult>(actionResult);
    }

    [Fact]
    public void GetToDosList_ReturnsAllItems(){
        var actionResult = _controller.GetToDosList() as OkObjectResult;
        var list = Assert.IsType<List<ToDoItem>>(actionResult.Value);
        Assert.Equal(6, list.Count);
    }

    [Fact]
    public void GetToDoByID_ReturnsOk_WhenFound()
    {
        // Given
        int testId = 3;
        // When
        var actionResult = _controller.GetToDoByID(testId);
        // Then
        Assert.IsType<OkObjectResult>(actionResult);
    }

    [Fact]
    public void GetToDoByID_ReturnsNotFound_WhenNotFound()
    {
        // Given
        int testId = 9;
        // When
        var actionResult = _controller.GetToDoByID(testId);
        // Then
        Assert.IsType<NotFoundResult>(actionResult);
    }

    [Fact]
    public void GetToDoByID_ReturnsRightItem_WhenFound()
    {
        // Given
        int testId = 4;
        // When
        var actionResult = _controller.GetToDoByID(testId) as OkObjectResult;
        // Then
        var item = actionResult.Value;
        Assert.IsType<ToDoItem>(item);
        Assert.Equal(testId, (item as ToDoItem).id);
    }
}