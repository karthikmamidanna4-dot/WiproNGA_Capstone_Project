using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Interfaces
{
    public interface ITicketCategoryRepository
    {
        IEnumerable<TicketCategory> GetAllCategories();

        void AddCategory(TicketCategory category);
    }
}