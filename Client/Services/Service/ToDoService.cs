using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SoulMate.Client.Services.IService;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Client.Services.Service
{
    public class ToDoService : IToDoService
    {
        private readonly UserState _userState;
        private readonly HttpClient _http;

        public ToDoService(UserState userState, HttpClient http)
        {
            _userState = userState;
            _http = http;
        }
        
        public async Task AddTodoITem(ToDoItemDto toDoItemDto)
        {
            toDoItemDto.UserName = _userState.UserName;
            await _http.PostAsJsonAsync("todo/addtodo", toDoItemDto);
        }

        public async Task<List<ToDoItemDto>> GetAllTodosToday()
        {
            var todoItem = new ToDoItemDto()
            {   
                UserName = _userState.UserName,
                TodoDate = DateTime.Now
            };
            var response = await _http.PostAsJsonAsync("todo/todos", todoItem);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ToDoItemDto>>();
            }

            return new List<ToDoItemDto>();
        }
    }
}