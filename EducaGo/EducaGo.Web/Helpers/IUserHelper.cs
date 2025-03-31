using EducaGo.Shared.DTO;
using EducaGo.Shared.Entities;
using EducaGo.Web.Migrations;
using Microsoft.AspNetCore.Identity;

namespace EducaGo.Web.Helpers
{
    public interface IUserHelper
    {
        Task<Usuario> GetUserAsync(string correo);
        Task<IdentityResult> AddUserAsync(Usuario usuario, string contraseña);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(Usuario usuario, string roleName);
        Task<bool> IsUserInRoleAsync(Usuario usuario, string roleName);
        Task<SignInResult> LoginAsync(LoginDTO login);
        Task LogoutAsync();
    }
}
