﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SoulMate.Server.Entities;
using SoulMate.Shared.UserModule;

namespace SoulMate.Server.Controllers
{
    [ApiController]
    [Route("authentication")]
    public class AuthenticateController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthenticateController(IConfiguration configuration, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            // 1.验证用户名和密码
            var loginResult = await _signInManager.PasswordSignInAsync(
                loginDto.UserName,
                loginDto.Password,
                false,
                false
                );

            if (!loginResult.Succeeded)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByNameAsync(loginDto.UserName);

            // 2.创建jwt
            // header
            var signingAlgorithm = SecurityAlgorithms.HmacSha256;

            // payload（自定义的用户数据）
            var claims = new List<Claim>()
            {
                // sub(用户id）
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
            };

            var roleNames = await _userManager.GetRolesAsync(user);
            foreach (var roleName in roleNames)
            {
                var roleClaim = new Claim(ClaimTypes.Role, roleName);
                claims.Add(roleClaim);
            }

            // signature
            var secretByte = Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]);
            var signingKey = new SymmetricSecurityKey(secretByte);
            var signingCredentials = new SigningCredentials(signingKey, signingAlgorithm);

            var token = new JwtSecurityToken(
                issuer: _configuration["Authentication:Issuer"],
                audience: _configuration["Authentication:Audience"],
                claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddDays(30),
                signingCredentials
            );

            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);

            // 3.return 200 ok + jwt
            return Ok(tokenStr);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            // 1.使用用户名创建用户对象
            var user = new ApplicationUser()
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email
            };

            // 2.hash密码，保存用户
            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest();
            }

            // 3.return
            return Ok();
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public IActionResult GetDataTest()
        {
            return Ok("Aatrowen");
        }
    }
}
