using System.Collections.Generic;
using Todo.Model;

namespace Todo.Api.Services
{
    public interface ITodoItemsService
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem GetTodo(int id);
        TodoItem Add(TodoItem item);
        TodoItem SetComplete(int id);
    }
}
