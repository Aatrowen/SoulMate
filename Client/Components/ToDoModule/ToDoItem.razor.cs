using Microsoft.AspNetCore.Components;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Components.ToDoModule
{
    public partial class ToDoItem
    {
        [Parameter] public ToDoItemDto ToDoItemDto { get; set; } = new ToDoItemDto();
    }
}