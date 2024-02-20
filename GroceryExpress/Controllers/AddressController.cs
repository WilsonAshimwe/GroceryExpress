using AutoMapper;
using GroceryExpress.API.DTO.Addresses;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroceryExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController(AddressService _addressService, IMapper _mapper) : ControllerBase
    {
        [HttpPut]
        public async Task<ActionResult<Basket>> Add([FromBody] UpdateAddressDTO dto)
        {

            Address address = await _addressService.Update(dto.Id, dto.Street, dto.Number, dto.Box, dto.City, dto.PostalCode);

            return Created("", _mapper.Map<ShowAddressDTO>(address));

        }
    }
}
