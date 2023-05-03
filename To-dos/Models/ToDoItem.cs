namespace To_dos.Models;

public class ToDoItem{
    public ToDoItem(int id, string text, Boolean state){
        this.id = id;
        this.text = text;
        this.state = state;
    }
    public int id { get; set; }
    public string? text { get; set; }
    public Boolean state { get; set; }
}