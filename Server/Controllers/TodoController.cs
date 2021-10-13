using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SoulMate.Server.Entities;
using SoulMate.Server.Services.IRepositories;
using SoulMate.Shared.ToDoModule;

namespace SoulMate.Server.Controllers
{
    [ApiController]
    [Route("todo")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodoController(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        [HttpPost("todos")]
        public async Task<ActionResult<List<ToDoItemDto>>> GetAllTodosToday(ToDoItemDto toDoItemDto)
        {
            var res = await _todoRepository.GetAllTodosToday(toDoItemDto.UserName, toDoItemDto.TodoDate);
            return Ok(_mapper.Map<List<ToDoItemDto>>(res));
        }

        [HttpPost("addtodo")]
        public async Task<ActionResult> AddTodoItem(ToDoItemDto addToDoItemDto)
        {
            var todoItemMap = _mapper.Map<TodoItem>(addToDoItemDto);
            bool res = await _todoRepository.AddTodoItem(addToDoItemDto.UserName, todoItemMap);
            if (res) return Ok();
            return BadRequest();
        }
    }
}