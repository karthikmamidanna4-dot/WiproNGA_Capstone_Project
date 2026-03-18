using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;
using CustomerSupportAPI.Data;

namespace CustomerSupportAPI.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _context;

        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.Find(id);
        }

        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        // NEW METHOD
        public void DeleteTicket(int id)
        {
            var ticket = _context.Tickets.Find(id);

            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
            }
        }

        // NEW METHOD
        public void UpdateTicket(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            _context.SaveChanges();
        }
    }
}