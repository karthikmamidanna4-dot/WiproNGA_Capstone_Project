using Microsoft.AspNetCore.Mvc;
using CustomerSupportAPI.Services;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomersController(CustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_service.GetCustomers());
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _service.CreateCustomer(customer);
            return Ok("Customer added successfully");
        }
    }
}