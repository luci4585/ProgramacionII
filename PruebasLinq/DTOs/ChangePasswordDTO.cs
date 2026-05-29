using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.DTOs
{
    public class ChangePasswordDTO
    {
        public string Username { get; set; } = "";
        public string OldPassword { get; set; } = "";
        public string NewPassword { get; set; } = "";
    }
}
