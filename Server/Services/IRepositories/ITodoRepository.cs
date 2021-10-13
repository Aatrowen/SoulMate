using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SoulMate.Server.Entities;

namespace SoulMate.Server.Services.IRepositories
{
    public interface ITodoRepository
    {
        /// <summary>
        /// 获取当天的所有待办
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="todayDateTime"></param>
        /// <returns></returns>
        public Task<List<TodoItem>> GetAllTodosToday(string userName, DateTime todayDateTime);

        /// <summary>
        /// 给特定用户添加待办
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="todoItem"></param>
        /// <returns></returns>
        public Task<bool> AddTodoItem(string userName, TodoItem todoItem);
    }
}