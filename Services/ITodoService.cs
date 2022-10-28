using TodoApp.Models;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        void AddTodo(TodoItem newItem);
        List<TodoItem> GetTodos();
        void UpdateTodo(TodoItem newItem);
        void UpdateTodoStatus(int id, TodoStatus status);
    }
}
