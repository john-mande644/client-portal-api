using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class AuthDTO
    {
        public class PostLoginCredentials
        {
            [JsonPropertyName("username")]
            public string Username { get; set; }
            [JsonPropertyName("password")]
            public string Password { get; set; }
        }
    }
}
