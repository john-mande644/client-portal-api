using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Auth
    {
        [Table("owd_users")]
        public class OwdUsers
        {
            [Key]
            public int id { get ; set; }
            public string login { get; set; }
            public int client_fkey { get; set; }
            public bool is_admin { get; set; }
            public string password { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public bool is_active { get; set; }
            public bool is_client_admin { get; set; }
        }
    }
}
