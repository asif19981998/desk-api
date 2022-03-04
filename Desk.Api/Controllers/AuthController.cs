using Desk.Core.Domain.Auth;
using Desk.Services.Auth;
using Desk.Services.Auth.JwtService;
using Desk.Services.Auth.Login.Models;
using Desk.Services.Auth.Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Desk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private IJwtService _jwtService;
        private IConfiguration configuration;

        public AuthController(
                //RoleManager<IdentityRole> roleManager,
                UserManager<ApplicationUser> userManager,
                SignInManager<ApplicationUser> signInManager,
                IConfiguration configuration,
                IJwtService jwtService
            
            )
        {
            //this.roleManager = roleManager;
            this.userManager = userManager;
            //this.signInManager = signInManager;
            this.configuration = configuration;
            this._jwtService = jwtService;

        }

        [HttpGet]
        public string Get()
        {
            return "Hi from login";
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                return Ok(new UserManagerResponse { Message = "Wrong Credentials", IsSuccess = false });
            }
            var claims = new[]
            {
                new Claim("email",model.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id),
                new Claim("name",user.FirstName),
            };
          
          var token =   _jwtService.Generate(claims);

           string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(new UserManagerResponse
            {
                
                Message = tokenAsString,
                IsSuccess = true,
                ExpireDate = token.ValidTo
            });



        }

        [HttpPost("Register")]

        public async Task<IActionResult> Register(AuthVM model)
        {
            if (model == null)
                throw new NullReferenceException("Model is null");

            if (model.Password != model.PasswordConfirm)
            {
                return Ok("fdf");
            }

            return Ok();
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            if (signInManager.IsSignedIn(User))
            {
                await signInManager.SignOutAsync();
            }
            return Ok(new UserManagerResponse { Message = "Logout successfully", IsSuccess = true });
        }






    }

    
}
