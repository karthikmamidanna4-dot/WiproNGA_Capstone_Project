using Microsoft.AspNetCore.Mvc;
using CustomerSupportAPI.Services;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketCategoriesController : ControllerBase
    {
        private readonly TicketCategoryService _service;

        public TicketCategoriesController(TicketCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_service.GetCategories());
        }

        [HttpPost]
        public IActionResult AddCategory(TicketCategory category)
        {
            _service.CreateCategory(category);
            return Ok("Category added successfully");
        }
    }
}