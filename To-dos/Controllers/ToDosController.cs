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

    [Route("GetAll")]
    [HttpGet]
    public IActionResult GetToDosList(){
        return Ok(_repository.GetAll());
    }
    
    [Route("GetById/{id?}")]
    [HttpGet]
    public IActionResult GetToDoByID(int id){
        var toDo = _repository.GetByID(id);
        if(toDo == null){
            return NotFound();
        }
        return Ok(toDo);
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