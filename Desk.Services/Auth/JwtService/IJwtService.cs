using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Auth.JwtService
{
    public interface IJwtService
    {
        JwtSecurityToken Generate(Claim[] claims);
        JwtSecurityToken Verify(string jwt);
    }
}
