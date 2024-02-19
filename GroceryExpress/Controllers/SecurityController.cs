using GroceryExpress.API.DTO.Login;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;
using SecurityManager;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class SecurityController(SecurityService _securityService, JWTManager _jwtManager) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto)
        {
            try
            {
                User user = await _securityService.Login(dto.Email, dto.Password);
                string token = _jwtManager.CreateToken(user.Email, user.Id.ToString(), user.Email, user.Role);
                return Ok(new { Token = token, Role = user.Role, displayName = user.LastName, Email = user.Email, Id = user.Id });
            }
            catch (ValidationException)
            {
                return BadRequest("Invalid Credentials");
            }
        }
    }
}
