﻿using System.Security.Claims;

namespace SmartShelter_WebAPI.Interfaces
{
    public interface IAuthService
    {
         Task<string> RegisterUser(LoginUser user);
         Task<bool> LoginUser(LoginUser user);
         Task<string> GenerateToken(LoginUser user);
         public ClaimsPrincipal? CheckToken(string token);
         public string GetTokenClaims(ClaimsPrincipal principal);
    }
}