using System.Collections.Generic;
using System.Threading.Tasks;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Services.IService
{
    public interface IToDoService
    {
        public Task AddTodoITem(ToDoItemDto toDoItemDto);

        public Task<List<ToDoItemDto>> GetAllTodosToday();
    }
}