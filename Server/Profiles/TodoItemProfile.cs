using AutoMapper;
using SoulMate.Server.Entities;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Server.Profiles
{
    public class TodoItemProfile : Profile
    {
        public TodoItemProfile()
        {
            CreateMap<TodoItem, ToDoItemDto>();
            CreateMap<ToDoItemDto, TodoItem>();
        }
    }
}