﻿using System;

namespace SoulMate.Shared.ToDoModule
{
    public class ToDoItemDto
    {
        public string UserName { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        
        public bool IsFinished { get; set; }

        public DateTime TodoDate { get; set; }

        public bool IsImportant { get; set; }

        public int RepeatTimes { get; set; }
    }
}