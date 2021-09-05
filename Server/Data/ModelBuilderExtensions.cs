using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SoulMate.Server.Entities;

namespace SoulMate.Server.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SetSeed(this ModelBuilder modelBuilder)
        {
            // 初始化用户与角色的种子数据
            // 1.更新用户与角色的外键
            modelBuilder.Entity<ApplicationUser>(u =>
                u.HasMany(x => x.UserRoles)
                    .WithOne().HasForeignKey(ur => ur.UserId).IsRequired());

            // 2.添加管理员角色
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new IdentityRole()
                {
                    Name = "User",
                    NormalizedName = "User".ToUpper()
                }
            );

            //// 3.添加用户
            //ApplicationUser adminUser = new ApplicationUser()
            //{
            //    Id = "90184155-dee0-40c9-bb1e-b5ed07afc04e",
            //    UserName = "Aatrowen",
            //    Email = "1402210387@qq.com",
            //    TwoFactorEnabled = false,
            //    EmailConfirmed = true,
            //    PhoneNumber = "19155063202",
            //    PhoneNumberConfirmed = false
            //};

            //adminUser.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(adminUser, "@Ydw123456");
            //modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            //// 4.给用户加入管理员角色
            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>()
            //    {
            //        RoleId = "308660dc-ae51-480f-824d-7dca6714c3e2",
            //        UserId = "90184155-dee0-40c9-bb1e-b5ed07afc04e"
            //    }
            //);
        }
    }
}
