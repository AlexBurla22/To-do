using To_dos.Models;

namespace To_dos.Repository{
    public interface IToDosRepository{
        IEnumerable<ToDoItem> GetAll();
        ToDoItem GetByID(int id);
        void Insert(ToDoItem item);
        void Update(ToDoItem item);
        void Remove(int id);
    }
}