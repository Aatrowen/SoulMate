namespace SoulMate.Client.Services.Service
{
    /// <summary>
    /// 用户状态信息
    /// </summary>
    public class UserState
    {
        /// <summary>
        /// 用户是否登录
        /// </summary>
        public bool IsLogin { get; set; } = true;

        public string UserName { get; set; } = "Aatrowen";

        /// <summary>
        /// JWT Token
        /// </summary>
        public string Token { get; set; }
    }
}
