using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {

        private readonly DataContext _dataContext;
        public TodoService (DataContext context)
        {
            _dataContext = context;
        }

        public void AddTodo(TodoItem newItem)
        {
            _dataContext.TodoItems.Add(newItem);
            _dataContext.SaveChanges();
        }

        public List<TodoItem> GetTodos()
        {
            return _dataContext.TodoItems.ToList();
        }

        public void UpdateTodo(TodoItem itemToUpdate)
        {
            /* SI FUERA UNA LISTA EN LUGAR DE UNA BASE DE DATOS 
            TodoItem itemUpdated = new TodoItem();
            foreach (TodoItem todo in todoList)
            {
                if (todo.Id == itemToUpdate.Id)
                {
                    todo.Title = itemToUpdate.Title;
                    todo.Description = itemToUpdate.Description;
                    itemUpdated = todo;
                }
            } */

            _dataContext.TodoItems.Update(itemToUpdate);
            _dataContext.SaveChanges();
        }

        public void UpdateTodoStatus(int id, TodoStatus status)
        {
            /*foreach (TodoItem todo in todoList)
            {
                if (todo.Id == id)
                {
                    todo.Status = status;
                }
            }*/

            var todoItem = _dataContext.TodoItems.Find(id);
            todoItem.Status = status;
            _dataContext.TodoItems.Update(todoItem);
            _dataContext.SaveChanges();
        }

    }
}
