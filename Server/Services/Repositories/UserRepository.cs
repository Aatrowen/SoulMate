using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoulMate.Server.Data;
using SoulMate.Server.Entities;
using SoulMate.Server.Services.IRepositories;

namespace SoulMate.Server.Services.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SoulDbContext _context;

        public UserRepository(SoulDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> GetByUserName(string userName)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }
    }
}
