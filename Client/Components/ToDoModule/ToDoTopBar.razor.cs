using System;
using Microsoft.AspNetCore.Components;

namespace SoulMate.Client.Components.ToDoModule
{
    public partial class ToDoTopBar
    {
        [Parameter] public DateTime DateToday { get; set; } = new DateTime();
    }
}