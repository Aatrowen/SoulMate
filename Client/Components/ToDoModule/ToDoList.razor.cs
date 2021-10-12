using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Components;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Components.ToDoModule
{
    public partial class ToDoList
    {
        [CascadingParameter] public IList<ToDoItemDto> ToDoItemDtos { get; set; } = new Collection<ToDoItemDto>();
    }
}