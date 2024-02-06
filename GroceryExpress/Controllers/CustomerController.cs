using GroceryExpress.API.DTO.Customers;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroceryExpress.API.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController(CustomerService _service) : ControllerBase
    {


        [HttpPost]
        public IActionResult Add([FromBody] CreateCustomerDTO customerDTO)
        {


            Customer customer = _service.Add(customerDTO.FirstName,
                                             customerDTO.LastName,
                                             customerDTO.Username,
                                             customerDTO.Email,
                                             customerDTO.PhoneNumber,
                                             customerDTO.BirthDate,
                                             customerDTO.Street,
                                             customerDTO.Number,
                                             customerDTO.Box,
                                             customerDTO.City,
                                             customerDTO.PostalCode

                );

            return Ok(customer);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            try
            {
                Customer? customer = _service.Get(id);
                return Ok(customer);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }

        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            try
            {
                _service.Delete(id);
                return Ok();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }


        }


        [HttpPost("{id}")]
        public IActionResult Update([FromBody] CreateCustomerDTO customerDTO, int id)
        {
            try
            {
                _service.Update(id,
                    customerDTO.FirstName,
                                    customerDTO.LastName,
                                    customerDTO.Username,
                                    customerDTO.Email,
                                    customerDTO.PhoneNumber,
                                    customerDTO.BirthDate,
                                    customerDTO.Street,
                                    customerDTO.Number,
                                    customerDTO.Box,
                                    customerDTO.City,
                                    customerDTO.PostalCode);
                return Ok();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }

        }






    }
}
