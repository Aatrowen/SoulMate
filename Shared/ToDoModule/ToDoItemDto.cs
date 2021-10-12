namespace SoulMate.Shared.ToDoModule
{
    public class ToDoItemDto
    {
        public string Title { get; set; }

        public string Description { get; set; }
        
        public bool IsFinished { get; set; }

        public bool IsImportant { get; set; }
    }
}