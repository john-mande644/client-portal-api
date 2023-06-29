using ClientPortal_API.DTOs.v1;

namespace ClientPortal_API.Services.v1
{
    public interface IAuthService
    {
        Task<AuthDTO.GetJwtToken> Authenticate(AuthDTO.PostLoginCredentials users);
    }
}
