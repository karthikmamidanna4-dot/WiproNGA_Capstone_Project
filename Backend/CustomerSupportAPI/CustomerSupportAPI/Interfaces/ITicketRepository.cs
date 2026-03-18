using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAllTickets();

        Ticket GetTicketById(int id);

        void AddTicket(Ticket ticket);
        void DeleteTicket(int id);
        void UpdateTicket(Ticket ticket);
    }
}