using System;
using System.Collections.Generic;
using Todo.Model;

namespace Todo.Api.Services
{
    public class TodoItemsService : ITodoItemsService
    {
        List<TodoItem> items = new List<TodoItem>();
        public TodoItemsService()
        {
            items.Add(new TodoItem { Id = 1, Name = "Item 1", IsComplete = false });
            items.Add(new TodoItem { Id = 2, Name = "Item 2", IsComplete = false });
            items.Add(new TodoItem { Id = 3, Name = "Item 3", IsComplete = false });
        }

        public TodoItem Add(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return items;
        }

        public TodoItem GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public TodoItem SetComplete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
