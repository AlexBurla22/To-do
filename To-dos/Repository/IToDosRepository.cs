using To_dos.Models;

namespace To_dos.Repository{
    public interface IToDosRepository{
        IEnumerable<ToDoItem> GetAll();
        ToDoItem GetByID(int id);
        ToDoItem Insert(ToDoItem item);
        ToDoItem Update(ToDoItem item);
        void Remove(int id);
    }
}