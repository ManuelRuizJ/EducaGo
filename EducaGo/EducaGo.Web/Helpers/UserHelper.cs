using EducaGo.Shared.DTO;
using EducaGo.Shared.Entities;
using EducaGo.Web.Data;
using EducaGo.Web.Migrations;
using Microsoft.AspNetCore.Identity;

namespace EducaGo.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly DataContext dataContext;
        private readonly UserManager<Usuario> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<Usuario> signInManager;
        public UserHelper(
             DataContext dataContext,
             UserManager<Usuario> userManager,
             RoleManager<IdentityRole> roleManager,
             SignInManager<Usuario> signInManager)
        {
            this.dataContext = dataContext;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }
        public async Task<IdentityResult> AddUserAsync(Usuario usuario, string contraseña)
        {
            return await userManager.CreateAsync(usuario, contraseña);
        }

        public async Task AddUserToRoleAsync(Usuario usuario, string rol)
        {
            await userManager.AddToRoleAsync(usuario, rol);
        }

        public async Task CheckRoleAsync(string rol)
        {
            bool rolExiste = await roleManager.RoleExistsAsync(rol);
            if (!rolExiste)
            {
                await roleManager.CreateAsync(
                    new IdentityRole
                    {
                        Name = rol,
                    });
            }
        }

        public async Task<Usuario> GetUserAsync(string correo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsUserInRoleAsync(Usuario usuario, string rol)
        {
            return await userManager.IsInRoleAsync(usuario, rol);
        }

        public async Task<SignInResult> LoginAsync(LoginDTO login)
        {
            return await signInManager.PasswordSignInAsync(login.Correo, login.Contraseña, false, false);
        }

        public async Task LogoutAsync()
        {
            await signInManager.SignOutAsync();
        }
    }
}
