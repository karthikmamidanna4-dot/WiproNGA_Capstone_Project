using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;
using CustomerSupportAPI.Data;

namespace CustomerSupportAPI.Repositories
{
    public class TicketCategoryRepository : ITicketCategoryRepository
    {
        private readonly AppDbContext _context;

        public TicketCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TicketCategory> GetAllCategories()
        {
            return _context.TicketCategories.ToList();
        }

        public void AddCategory(TicketCategory category)
        {
            _context.TicketCategories.Add(category);
            _context.SaveChanges();
        }
    }
}