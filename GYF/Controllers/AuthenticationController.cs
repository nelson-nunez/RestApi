﻿using GYF.Business;
using GYF.DataAccess;
using GYF.Model.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GYF.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : Controller
    {
        private readonly AuthenticationBusiness authenticationBusiness;
        private readonly UnitOfWork unitOfWork;
        public IConfiguration Configuration { get; }


        public AuthenticationController(AuthenticationBusiness authenticationBusiness, UnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.authenticationBusiness = authenticationBusiness;
            this.unitOfWork = unitOfWork;
            Configuration = configuration;
        }

        //Se podria agregar url encoded para mayor seguridad, tambien un objeto request signin
        [HttpPost("Authenticate")]
        public async Task<ActionResult> Authenticate([FromQuery] string username, [FromQuery] string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                throw new Exception("Usuario y Contraseña requeridos.");

            await authenticationBusiness.Authenticate(username, password);
      
            #region Token
            var claimList = new[] 
            { 
                new Claim("UserId", username),
                new Claim(ClaimTypes.Name, username),
            };

            var jwtResult = GenerateTokens(username, claimList, DateTime.Now, 200);
            #endregion

            return Ok(jwtResult);
        }

        public async Task<JwtAuthResult> GenerateTokens(string username, Claim[] claims, DateTime now, int accessTokenExpiration)
        {
            var claimList = new List<Claim>(claims);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(1);

            var jwtToken = new JwtSecurityToken(
                Configuration["JwtIssuer"],
                Configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );
            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return new JwtAuthResult
            {
                AccessToken = accessToken,
            };
        }
    }
}
