using System;

namespace SoulMate.Server.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime TodoDate { get; set; }
        
        public bool IsFinished { get; set; }

        public bool IsImportant { get; set; }

        public int RepeatTimes { get; set; }

        public ApplicationUser User { get; set; }
    }
}