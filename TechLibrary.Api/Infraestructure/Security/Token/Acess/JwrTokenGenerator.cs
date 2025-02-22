using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infrastructure.Security.Token.Acess;

public class JwrTokenGenerator
{
    public string Generate(User user)
    {
        var claims = new List<Claim>()
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString())
        };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Expires = DateTime.UtcNow.AddMinutes(60),
            Subject = new ClaimsIdentity(claims),
            SigningCredentials = new SigningCredentials(SecurityKey(), SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var securityToken = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(securityToken);
    }

    private static SymmetricSecurityKey SecurityKey()
    {
        var signingKey = "M3pS4z0anH3mA6tmrGHT2O54556HB4oD";

        var symmetricKey = Encoding.UTF8.GetBytes(signingKey);

        return new SymmetricSecurityKey(symmetricKey);
    }
}
