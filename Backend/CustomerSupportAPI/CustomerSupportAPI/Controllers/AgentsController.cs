using Microsoft.AspNetCore.Mvc;
using CustomerSupportAPI.Services;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgentsController : ControllerBase
    {
        private readonly AgentService _service;

        public AgentsController(AgentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAgents()
        {
            return Ok(_service.GetAgents());
        }

        [HttpPost]
        public IActionResult AddAgent(Agent agent)
        {
            _service.CreateAgent(agent);
            return Ok("Agent added successfully");
        }
    }
}