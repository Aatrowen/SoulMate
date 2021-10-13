using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoulMate.Server.Data;
using SoulMate.Server.Entities;
using SoulMate.Server.Services.IRepositories;

namespace SoulMate.Server.Services.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly SoulDbContext _context;
        private readonly IUserRepository _userRepository;

        public TodoRepository(SoulDbContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }
        
        public async Task<List<TodoItem>> GetAllTodosToday(string userName, DateTime todayDateTime)
        {
            // var user = await _userRepository.GetByUserName(userName);

            var userTodos = _context.TodoItems.Where(x => x.User.UserName == userName
                                                    && x.TodoDate.Date == todayDateTime.Date).ToList();
            
            var sortedTodoItems = new List<TodoItem>();
            sortedTodoItems.AddRange(userTodos.Where(x => 
                x.IsFinished == false && x.IsImportant == true));
            sortedTodoItems.AddRange(userTodos.Where(x => 
                x.IsFinished == false && x.IsImportant == false));
            sortedTodoItems.AddRange(userTodos.Where(x =>
                x.IsFinished == true));
            return sortedTodoItems;
        }

        public async Task<bool> AddTodoItem(string userName, TodoItem todoItem)
        {
            var user = await _userRepository.GetByUserName(userName);
            user.TodoItems.Add(todoItem);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}