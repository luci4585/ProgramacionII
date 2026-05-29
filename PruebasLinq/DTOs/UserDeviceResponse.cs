using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.DTOs
{
    public sealed class UserDeviceResponse
    {
        public long Id { get; set; }
        public string Platform { get; set; } = default!;
        public string? Browser { get; set; }
        public string? DeviceName { get; set; }
        public bool PwaInstalled { get; set; }
        public bool IsEnabled { get; set; }
        public DateTimeOffset LastSeenUtc { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset UpdatedUtc { get; set; }
        public DateTimeOffset? RevokedUtc { get; set; }
        public int FailureCount { get; set; }
    }
}
