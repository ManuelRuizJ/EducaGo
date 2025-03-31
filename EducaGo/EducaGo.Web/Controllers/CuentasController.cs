using EducaGo.Shared.DTO;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EducaGo.Web.Helpers;
using EducaGo.Web.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using EducaGo.Shared.Entities;

namespace EducaGo.Web.Controllers
{
    public class CuentasController : Controller
    {
        private readonly IUserHelper userHelper;
        private readonly IConfiguration configuration;

        public CuentasController(IUserHelper userHelper, IConfiguration configuration)
        {
            this.userHelper = userHelper;
            this.configuration = configuration;
        }
        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var result = await userHelper.LoginAsync(loginDTO);
            if (result.Succeeded)
            {
                var user = await userHelper.GetUserAsync(loginDTO.Correo);
                return Ok(user);
            }
            return BadRequest("Usuario o contraseña incorrecta");
        }
        private object? BuildToken(Usuario usuario)
        {
            var claims = new List<Claim>
             {
                //HAY QUE HACER CAMBIO
             new Claim(ClaimTypes.Name,usuario.Correo!),
             new Claim(ClaimTypes.Role,usuario.Rol,
             new Claim("Nombre",usuario.Nombre)
             };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwtKey"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiracion = DateTime.UtcNow.AddDays(10);
            var token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiracion,
                signingCredentials: credentials);
            return new TokenDTO
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiracion = expiracion
            };
        }
    }
}
