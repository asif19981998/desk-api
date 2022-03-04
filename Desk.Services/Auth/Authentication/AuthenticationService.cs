using Desk.Core.Domain.Auth;
using Desk.Services.Auth.Authentication.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Auth.Authentication
{

    public class AuthenticationService : IAuthenticationService
    {


        private UserManager<ApplicationUser> userManager;



        public AuthenticationService(UserManager<ApplicationUser> userManager)
        {

            this.userManager = userManager;


        }



        public async Task<IdentityResult> RegisterByCreatingAsync(AuthVM model)
        {


            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                ProfileImageId =0
                //FirstName=model.FirstName,
                //LastName = model.LastName

            };

            var data = await userManager.CreateAsync(user, model.Password);

            return data;



        }

        
    }

}
