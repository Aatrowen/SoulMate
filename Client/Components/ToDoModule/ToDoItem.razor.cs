using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Components.ToDoModule
{
    public partial class ToDoItem
    {
        [Parameter] public ToDoItemDto ToDoItemDto { get; set; } = new ToDoItemDto();

        public void TodoItemClicked()
        {
            ToDoItemDto.Title = "阿的江法律的看法";
        }

        private void TodoFinishClicked()
        {
            ToDoItemDto.IsFinished = !ToDoItemDto.IsFinished;
        }

        private void TodoImportantClicked()
        {
            ToDoItemDto.IsImportant = !ToDoItemDto.IsImportant;
        }
    }
}