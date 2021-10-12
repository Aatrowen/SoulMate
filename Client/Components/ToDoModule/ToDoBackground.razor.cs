using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Components.ToDoModule
{
    public partial class ToDoBackground
    {
        [CascadingParameter] public IList<ToDoItemDto> ToDoItemDtos { get; set; }
    }
}