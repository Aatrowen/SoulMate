using System;
using System.Collections.Generic;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Pages.ToDoModule
{
    public partial class ToDoView
    {
        public DateTime DateToday { get; set; } = new DateTime();
        
        public List<ToDoItemDto> ToDoItemDtos { get; set; } = new List<ToDoItemDto>()
        {
            new ToDoItemDto() {Title = "aaaaa", Description = "aaaaaaaaaaaaaaaaaaaaaaaa"},
            new ToDoItemDto() {Title = "bbb", Description = "bbbbbbbbbbbbbbbbbbbbbbbbbbb"},
            new ToDoItemDto() {Title = "ccc", Description = "cccccccccccccccccccccc"},
            new ToDoItemDto() {Title = "ddd", Description = "dddddddddddddddddd"},
            new ToDoItemDto() {Title = "eeeee", Description = "eeeeeeeeeeeeeeeeeeee"}
        };

        protected override void OnInitialized()
        {
            DateToday = DateTime.Now;
        }
    }
}