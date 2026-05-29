using InstitutoServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Models.Login
{
    public class LoginResponse
    {
        public FirebaseUser User { get; set; }
        public string Error { get; set; }
        public string Jwt { get; set; }
        public RegisterDeviceRequest? DeviceRegistration { get; set; }
    }
}
