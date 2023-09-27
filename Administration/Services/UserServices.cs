using Administration.Helpers;
using Administration.Interfaces;
using Administration.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models.DTO;
using Models.Entities;
using Services.FND;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Administration.Services
{
    public class UserServices : IUserInterface
    {
        private readonly AppSettings _appSettings;
        //private readonly DbNskContext _dbNskContext;
        /*
        public UserServices(IOptions<AppSettings> appSettings, DbNskContext dbNskContext)
        {
            _appSettings = appSettings.Value;
            _dbNskContext = dbNskContext;
        }
        */
        public UserServices(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            UserService usr = new UserService();
            var user = usr.GetUserByParam(model.Username);//_dbNskContext.Users.SingleOrDefault(u => u.Username == model.Username);

            if (user == null /*|| !BCrypt.Net.BCrypt.Verify(model.Password, user.Password)*/)
            {
                return null;
            }

            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }
        private string generateJwtToken(UserDTO user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
