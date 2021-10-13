using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SoulMate.Client.Services.IService;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Pages.ToDoModule
{
    public partial class ToDoView
    {
        [Inject] public IToDoService ToDoService { get; set; }
        public DateTime DateToday { get; set; } = new DateTime();

        public List<ToDoItemDto> ToDoItemDtos { get; set; } = new List<ToDoItemDto>();

        protected override async Task OnInitializedAsync()
        {
            ToDoItemDtos = await ToDoService.GetAllTodosToday();
        }
    }
}