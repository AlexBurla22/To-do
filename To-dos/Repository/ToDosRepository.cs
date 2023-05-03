using To_dos.Models;

namespace To_dos.Repository{
    public class ToDosRepository: IToDosRepository{
        List<ToDoItem> _toDoItems = new List<ToDoItem> {
            new ToDoItem(1, "spalat rufe", false),
            new ToDoItem(2, "plimbat caine", false),
            new ToDoItem(3, "facut mancare", false),
            new ToDoItem(4, "returnat carte", true),
            new ToDoItem(5, "dus gunoi", false),
            new ToDoItem(6, "mers la sala", true),
        };

        public IEnumerable<ToDoItem> GetAll()
        {
            return _toDoItems;
        }

        public ToDoItem GetByID(int id)
        {
            return _toDoItems.Find(item => item.id == id);
        }

        public ToDoItem Insert(ToDoItem toDo)
        {
            _toDoItems.Add(toDo);
            return toDo;
        }

        public void Remove(int id)
        {
            var result = _toDoItems.Find(item => item.id == id);
            _toDoItems.Remove(result);
        }

        public ToDoItem Update(ToDoItem toDo)
        {
            var index = _toDoItems.FindIndex(item => item.id == toDo.id);
            _toDoItems[index] = toDo;
            return toDo;
        }
    }
}