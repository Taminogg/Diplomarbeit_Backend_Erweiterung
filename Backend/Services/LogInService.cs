using Backend.Dtos;
using ContainerToolDB;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Backend.Services
{
    public class LogInService
    {
        private readonly ContainerToolDBContext _db;
        private readonly IDataProtectionProvider _idp;
        private readonly IHttpContextAccessor _accessor;
        private readonly string _jwtKey;

        public LogInService(ContainerToolDBContext db, IDataProtectionProvider idp, IHttpContextAccessor accessor, IConfiguration configuration)
        {
            _db = db;
            _idp = idp;
            _accessor = accessor;
            _jwtKey = configuration.GetValue<string>("JwtKey");
        }

        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
