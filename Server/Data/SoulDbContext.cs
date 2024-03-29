﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoulMate.Server.Entities;

namespace SoulMate.Server.Data
{
    public class SoulDbContext : IdentityDbContext<ApplicationUser>
    {
        public SoulDbContext(DbContextOptions<SoulDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 添加数据库种子数据
            modelBuilder.SetSeed();
        }
    }
}
