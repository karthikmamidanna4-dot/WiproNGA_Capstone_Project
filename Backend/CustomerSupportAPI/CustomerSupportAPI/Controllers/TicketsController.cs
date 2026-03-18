using Microsoft.AspNetCore.Mvc;
using CustomerSupportAPI.Services;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly TicketService _service;

        public TicketsController(TicketService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            return Ok(_service.GetAllTickets());
        }

        [HttpGet("{id}")]
        public IActionResult GetTicketById(int id)
        {
            return Ok(_service.GetTicketById(id));
        }

        [HttpPost]
        public IActionResult AddTicket(Ticket ticket)
        {
            _service.CreateTicket(ticket);
            return Ok("Ticket created successfully");
        }

        // DELETE Ticket
        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            _service.DeleteTicket(id);
            return Ok("Ticket deleted successfully");
        }

        // RESOLVE Ticket
        [HttpPut("resolve/{id}")]
        public IActionResult ResolveTicket(int id)
        {
            var ticket = _service.GetTicketById(id);

            if (ticket == null)
            {
                return NotFound();
            }

            ticket.Status = "Closed";
            ticket.ResolvedDate = DateTime.Now;

            _service.UpdateTicket(ticket);

            return Ok("Ticket resolved successfully");
        }
    }
}