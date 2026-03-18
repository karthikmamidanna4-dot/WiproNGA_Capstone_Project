using Microsoft.EntityFrameworkCore;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<TicketCategory> TicketCategories { get; set; }
    }
}
