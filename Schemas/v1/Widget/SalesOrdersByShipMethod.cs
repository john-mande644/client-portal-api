using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class SalesOrdersByShipMethod
        {
            public int ClientId { get; set; }
            public DateTime Date { get; set; } = default!;
            public  string Method { get; set; } = default!;
            public int Total { get; set; } = default!;
        }
    }
}
