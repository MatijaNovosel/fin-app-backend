using fin_app_backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;

namespace fin_app_backend.Services.Interfaces
{
  public interface IAuthService
  {
    Task<AuthResultModel> Register(RegistrationModel payload);
    Task<AuthResultModel> Login(LoginModel payload);
    ClaimsPrincipal GetUser();
  }
}