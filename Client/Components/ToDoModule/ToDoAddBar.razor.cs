using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SoulMate.Client.Services.IService;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Components.ToDoModule
{
    public partial class ToDoAddBar
    {
        [Inject] public IToDoService ToDoService { get; set; }
        public ToDoItemDto AddTodoItemDto { get; set; } = new ToDoItemDto();

        public async Task OnInputEnter()
        {
            AddTodoItemDto.TodoDate = DateTime.Now;
            await ToDoService.AddTodoITem(AddTodoItemDto);
            AddTodoItemDto = new ToDoItemDto();
            await InvokeAsync(StateHasChanged);
        }
    }
}