using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.DTOs
{
    public sealed class SessionResponse
    {
        public int UserId { get; set; }
        public bool LinkedByUid { get; set; }
        public bool LinkedByEmail { get; set; }
        public bool CreatedNewUser { get; set; }
        public DateTimeOffset LastLoginUtc { get; set; }
        public string? Email { get; set; }
    }
}
