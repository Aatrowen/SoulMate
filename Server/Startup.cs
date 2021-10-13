using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using SoulMate.Server.Data;
using SoulMate.Server.Entities;
using SoulMate.Server.Services.IRepositories;
using SoulMate.Server.Services.Repositories;

namespace SoulMate.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // 使用 IDentity EF Core 
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<SoulDbContext>();

            // 添加AutoMapper，扫描所有的profile文件
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // 身份认证与授权
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    var secretByte = Encoding.UTF8.GetBytes(Configuration["Authentication:SecretKey"]);
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = Configuration["Authentication:Issuer"],

                        ValidateAudience = true,
                        ValidAudience = Configuration["Authentication:Audience"],

                        ValidateLifetime = true,

                        IssuerSigningKey = new SymmetricSecurityKey(secretByte)
                    };
                });

            // 添加Controller服务
            services.AddControllersWithViews();
            services.AddRazorPages();

            // 添加数据库连接服务（MySql）
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            services.AddDbContext<SoulDbContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(Configuration.GetConnectionString("MySqlConnection"), serverVersion)
                    .EnableSensitiveDataLogging()
            );

            // 注册自定义的服务
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITodoRepository, TodoRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
