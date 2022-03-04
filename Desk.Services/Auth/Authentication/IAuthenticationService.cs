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
    public interface IAuthenticationService
    {
        
        Task<IdentityResult> RegisterByCreatingAsync(AuthVM entity);
    }


}
