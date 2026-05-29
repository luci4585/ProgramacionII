using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.DTOs
{
    public sealed class RegisterDeviceRequest
    {
        public string FcmToken { get; set; } = default!;
        public string Platform { get; set; } = "web";      // "web", "android", "ios"
        public string? Browser { get; set; }               // "Chrome", "Edge", "Safari", etc.
        public string? DeviceName { get; set; }            // Alias amigable
        public bool PwaInstalled { get; set; }
    }
}
