using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SoulMate.Server.Entities
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
    }
}
