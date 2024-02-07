using AutoMapper;
using GroceryExpress.API.DTO.Users;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace GroceryExpress.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController(UserService _service, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<User, ShowUserDTO>());
            var users = await _service.GetAll();
            var results = mapper.Map<List<User>, List<ShowUserDTO>>(users);

            return Ok(results);
        }


        [HttpPost]
        public async Task<ActionResult<User>> Add([FromBody] CreateUserDTO userDTO)
        {


            User user = await _service.Add(userDTO.FirstName,
                                             userDTO.LastName,
                                             userDTO.Username,
                                             userDTO.Email,
                                             userDTO.PhoneNumber,
                                             userDTO.BirthDate,
                                             userDTO.Street,
                                             userDTO.Number,
                                             userDTO.Box,
                                             userDTO.City,
                                             userDTO.PostalCode

                );

            return Ok(mapper.Map<ShowUserDTO>(user));
        }

        [HttpGet("{id}")]
        // [Authorize]
        public async Task<ActionResult<User?>> Get([FromRoute]int id, bool includeAddress)
        {
            try
            {
                //if(id.ToString() != User.FindFirstValue(ClaimTypes.NameIdentifier) && !User.IsInRole("ADMIN"))
                //{
                //    return Forbid();
                //}

                if (includeAddress)
                {  
                    User? user = await _service.GetWithAddress(id);
                return Ok(mapper.Map<User, ShowUserDTO>(user));
                
                }else
                {
                    User? user = await _service.Get(id);
                    return Ok(mapper.Map<User,ShowUserWithoutAddressDTO>(user));

                }
               
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }

        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id) {
            try
            {
                await _service.Delete(id);
                return NoContent();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }


        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] CreateUserDTO userDTO, int id)
        {
            try
            {
                var user= await _service.Update(id,
                    userDTO.FirstName,
                                    userDTO.LastName,
                                    userDTO.Username,
                                    userDTO.Email,
                                    userDTO.PhoneNumber,
                                    userDTO.BirthDate,
                                    userDTO.Street,
                                    userDTO.Number,
                                    userDTO.Box,
                                    userDTO.City,
                                    userDTO.PostalCode);
                return Ok(mapper.Map<ShowUserDTO>(user));

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }

        }






    }
}
