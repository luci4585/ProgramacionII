using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.DTOs
{
    //lo traje de mis transferencias para solucionar la reconexión en el desktop después de que el jwt caduque, todavía no lo implementé, pero la idea es que el JwtAuthHandler lo use para hacer login automático y refrescar el token
    public class LoginDTO
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string VersionDesktop { get; set; }= "";
    }
}
