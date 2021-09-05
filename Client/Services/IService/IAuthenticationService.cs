using System.Threading.Tasks;
using SoulMate.Shared.UserModule;

namespace SoulMate.Client.Services.IService
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// 验证用户是否登录成功
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <returns></returns>
        Task<bool> LoginValidate(LoginDto loginInfo);
    }
}
