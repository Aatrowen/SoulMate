using System.Threading.Tasks;
using SoulMate.Server.Entities;

namespace SoulMate.Server.Services.IRepositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// 通过用户名查找返回用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<ApplicationUser> GetByUserName(string userName);
    }
}
