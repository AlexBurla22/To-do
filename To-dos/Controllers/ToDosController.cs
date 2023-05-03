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

    [Route("AddToDo")]
    [HttpPost]
    public IActionResult AddToDo(ToDoItem toDo){
        var toDoAdded = _repository.Insert(toDo);
        return CreatedAtAction("Get", new {id = toDoAdded.id}, toDoAdded);
    }

    [Route("Delete/{id?}")]
    [HttpDelete] 
    public IActionResult RemoveToDo(int id){
        var toBeRemoved = _repository.GetByID(id);
        if(toBeRemoved == null){
            return NotFound();
        }
        _repository.Remove(toBeRemoved.id);
        return NoContent();
    }

    [Route("Update/{id?}")]
    [HttpPost]
    public IActionResult UpdateToDo(ToDoItem toDo){
        var toBeUpdated = _repository.GetByID(toDo.id);
        if(toBeUpdated == null){
            return NotFound();
        }
        var updatedToDo = _repository.Update(toDo);
        return CreatedAtAction("Get", new {id = updatedToDo.id}, updatedToDo);
    }
}