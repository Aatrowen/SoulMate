using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace SoulMate.Client.Pages.MainViewModule
{
    public partial class MainView
    {
        [Inject] public HttpClient HttpClient { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _userState.Token);
        //    GetDataTest = await HttpClient.GetStringAsync("authentication");
        //}

    }
}
