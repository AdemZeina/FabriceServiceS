using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DataProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IActionResult GetToken()
        {
            //security key
            string securityKey = "493ab24b-0c99-3341-bf32-76037c2f36eb$localhost:52020";
            //symmetric security key
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            //signing credentials
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            //add claims
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            claims.Add(new Claim(ClaimTypes.Role, "Reader"));
            //claims.Add(new Claim("Id", "110"));


            //create token
            var token = new JwtSecurityToken(
                issuer: "localhost:52020",
                audience: "readers",
                expires: DateTime.Now.AddHours(1), // New token will change every 60 minutes.
                signingCredentials: signingCredentials
                , claims: claims
            );

            //return token
            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}