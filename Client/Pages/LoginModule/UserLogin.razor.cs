using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SoulMate.Client.Services.IService;
using SoulMate.Shared.UserModule;

namespace SoulMate.Client.Pages.LoginModule
{
    public partial class UserLogin
    {
        [Inject]public IAuthenticationService AuthenticationService { get; set; }

        // 定义一个变量 LoginDto 用来保存用户输入的用户名和密码
        private LoginDto LoginDto { get; set; } = new LoginDto();

        // 这个变量用来判断表单是否加载
        private bool _loading = false;

        // 当用户点击了登录按钮时执行的函数
        async Task LoginSubmit()
        {
            _loading = true; // 让表单变为加载状态

            // 判断用户输入的用户名和密码 已经在后端完成了 
            // 我们只需要获取后端返回的结果 所以定义一个 response变量保存后端验证的结果(bool)
            bool res = await AuthenticationService.LoginValidate(loginInfo: LoginDto);

            // 如果登录成功 就跳出欢迎用户的消息，否则显示登录失败
            if (res)
            {
                // 显示欢迎信息
                await _message.Success($"欢迎您！{LoginDto.UserName}", 0.8);
                await _message.Success(_userState.Token, 0.8);

                // 随后跳转到会员管理的页面
                _navigationManager.NavigateTo("");
            }
            else
            {
                // 显示登录失败的信息
                await _message.Error("登录失败", 0.8);

                // 表单取消加载状态
                _loading = false;
            }
        }
    }
}
