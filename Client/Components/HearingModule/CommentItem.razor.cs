using Microsoft.AspNetCore.Components;
using SoulMate.Shared.HearingModule;

namespace SoulMate.Client.Components.HearingModule
{
    public partial class CommentItem
    {
        [Parameter] public CommentItemDto CommentItemDto { get; set; } = new CommentItemDto();
    }
} 