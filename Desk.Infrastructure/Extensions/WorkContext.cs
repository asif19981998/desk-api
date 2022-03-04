﻿using Desk.Core.Domain.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Extensions
{
    public class WorkContext : IWorkContext
    {
        private const bool IsInDevelopment = true;
        private ApplicationUser _currentUser;
        private UserManager<ApplicationUser> _userManager;
        private HttpContext _httpContext;

        public WorkContext(UserManager<ApplicationUser> userManager,
                           IHttpContextAccessor contextAccessor)
        {
            _userManager = userManager;
            _httpContext = contextAccessor.HttpContext;
        }

        public async Task<ApplicationUser> GetCurrentUserAsync()
        {
            if (IsInDevelopment)
            {
                return _userManager.Users.FirstOrDefault();
            }
            else
            {
                var contextUser = _httpContext.User;
                _currentUser = await _userManager.GetUserAsync(contextUser);

                if (_currentUser != null)
                {
                    return _currentUser;
                }
                return _currentUser;
            }
           
        }


        public async Task<bool> IsUserSignedIn()
        {
            var contextUser = _httpContext.User;
            _currentUser = await _userManager.GetUserAsync(contextUser);

            if (_currentUser != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
