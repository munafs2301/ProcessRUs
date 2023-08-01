using Microsoft.IdentityModel.Tokens;
using ProcessRUs.Data;
using ProcessRUs.DTOs;
using ProcessRUs.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProcessRUs.Helpers
{
    public class IdentityHelper
    {
        private readonly ProcessRUsContext _context;
        private readonly IConfiguration _configuration;

        public IdentityHelper(ProcessRUsContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public User AuthenticateUser(UserInfo userLogin)
        {
            return _context.Users.FirstOrDefault(x => x.Email == userLogin.Email && x.Password == userLogin.Password);
        }

        public string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var securityToken = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.Now.AddHours(1), signingCredentials: credentials);
            var token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;
        }
    }
}
