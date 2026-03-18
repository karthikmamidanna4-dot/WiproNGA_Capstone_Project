using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Services
{
    public class TicketService
    {
        private readonly ITicketRepository _repository;

        public TicketService(ITicketRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _repository.GetAllTickets();
        }

        public Ticket GetTicketById(int id)
        {
            return _repository.GetTicketById(id);
        }

        public void CreateTicket(Ticket ticket)
        {
            _repository.AddTicket(ticket);
        }

        // NEW METHOD
        public void DeleteTicket(int id)
        {
            _repository.DeleteTicket(id);
        }

        // NEW METHOD
        public void UpdateTicket(Ticket ticket)
        {
            _repository.UpdateTicket(ticket);
        }
    }
}