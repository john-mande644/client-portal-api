using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1;

public partial class AuthDTO
{
    public class GetJwtToken
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }
}
