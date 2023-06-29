using Microsoft.IdentityModel.Tokens;
using ClientPortal_API.Schemas.v1;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using ClientPortal_API.Data.v1;
using Microsoft.EntityFrameworkCore;
using ClientPortal_API.DTOs.v1;

namespace ClientPortal_API.Services.v1
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public AuthService(IConfiguration config, IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
            _config = config;
        }

        /// <summary>
        /// Returns a JWT token containing the Clients claims validated by Username and Password
        /// </summary>
        /// <param name="userCreds"> Username and Password</param>
        /// <returns></returns>
        public async Task<AuthDTO.GetJwtToken> Authenticate(AuthDTO.PostLoginCredentials userCreds)
        {
            Auth.OwdUsers? owdUser = new Auth.OwdUsers();
            try
            {
                owdUser = await _context.owdUsers.Where(x => x.login.Equals(userCreds.Username)).Where(y => y.password.Equals(userCreds.Password)).FirstOrDefaultAsync();
               
                if (owdUser != null)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var tokenKey = Encoding.UTF8.GetBytes(_config["JWT:Key"]);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("name", owdUser.name),
                            new Claim("client_id", owdUser.client_fkey.ToString()),
                            new Claim("email", owdUser.email),
                            new Claim("is_admin", owdUser.is_admin.ToString()),
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(10),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    return new AuthDTO.GetJwtToken { Token = tokenHandler.WriteToken(token) };
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
     
        }
    }
}
