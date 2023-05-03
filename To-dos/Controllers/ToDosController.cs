using Microsoft.AspNetCore.Mvc;
using To_dos.Repository;
using To_dos.Models;

namespace To_dos.Controllers;

[ApiController]
[Route("[controller]")]

public class ToDosController: Controller{

    IToDosRepository _repository;

    public ToDosController(){
        _repository = new ToDosRepository();
    }

    [Route("ListAll")]
    [HttpGet]
    public IActionResult GetToDosList(){
        return Ok(_repository.GetAll());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetToDoByID(int id){
        return NoContent();
    }

    [HttpPost]
    public IActionResult AddToDo(ToDoItem item){
        return NoContent();
    }

    [HttpDelete("{id}")] 
    public IActionResult RemoveToDo(int id){
        return NoContent();
    }
}