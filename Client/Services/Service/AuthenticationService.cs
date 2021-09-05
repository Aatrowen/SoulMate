using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SoulMate.Client.Services.IService;
using SoulMate.Shared.UserModule;

namespace SoulMate.Client.Services.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _http;
        private readonly UserState _userState;

        public AuthenticationService(HttpClient httpClient, UserState userState)
        {
            _http = httpClient;
            _userState = userState;
        }

        public async Task<bool> LoginValidate(LoginDto loginInfo)
        {
            var response = await _http.PostAsJsonAsync("authentication/login", loginInfo);

            if (response.IsSuccessStatusCode)
            {
                _userState.IsLogin = true;
                _userState.UserName = loginInfo.UserName;
                _userState.Token = response.Content.ReadAsStringAsync().Result;
                return true;
            }

            return false;
        }
    }
}
