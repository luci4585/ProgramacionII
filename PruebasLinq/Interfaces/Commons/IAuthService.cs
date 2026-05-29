using InstitutoServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Interfaces
{
    //lo traje de mis transferencias para solucionar la reconexión en el desktop después de que el jwt caduque, todavía no lo implementé, pero la idea es que el JwtAuthHandler lo use para hacer login automático y refrescar el token
    public interface IAuthService
    {
        Task<bool> Login(LoginDTO login);
        Task<bool> ResetPassword(LoginDTO? login);
        Task<bool> CreateUserWithEmailAndPasswordAsync(string email, string password, string nombre);
        Task<bool> ChangePasswordAsync(ChangePasswordDTO? changeDTO);
    }
}
